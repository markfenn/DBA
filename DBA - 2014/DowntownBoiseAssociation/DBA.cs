namespace DowntownBoiseAssociation
{
    using System;
    using System.ComponentModel;
    using System.Data.Linq;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;

    public static class XMLUtility
    {
        public static XElement SerializeObject(object pObject)
        {
            XmlSerializer xs = new XmlSerializer(pObject.GetType());
            Stream stream = new MemoryStream();
            xs.Serialize(stream, pObject);
            stream.Seek(0, SeekOrigin.Begin);
            XmlReader reader = XmlReader.Create(stream);
            XElement xele = XElement.Load(reader);
            return xele;
        }

        public static T DeserializeObject<T>(XElement xElement)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            XmlReader reader = xElement.CreateReader();
            return (T)xs.Deserialize(reader);
        }
    }

    public partial class DBADataContext : System.Data.Linq.DataContext
    {
        public bool Changed()
        {
            ChangeSet cs = this.GetChangeSet();
            return (cs.Deletes.Count > 0) || (cs.Inserts.Count > 0) || (cs.Updates.Count > 0);
        }

        public IEnumerable<string> AttributeNames()
        {
            Assembly asm = Assembly.GetCallingAssembly();

            // find all the types descending from DynamicAttributes
            var types = from t in asm.GetTypes()
                        where t.IsSubclassOf(typeof(DynamicAttributes))
                        select t;

            List<string> values = new List<string>();

            // create an instance of each type, cast it as DynamicAttributes and append it's attributes
            foreach (var itemType in types)
            {
                DynamicAttributes obj = (DynamicAttributes)Activator.CreateInstance(itemType);
                values.AddRange(obj.AttributeNames());
            }
            return values;
        }

        public void CloseAccountingPeriod()
        {
            // close the current month by moving the Control Record to the current month
            sp_SetAccountingPeriod();

            // If we are also closing the year, then add Beginning Balance Records for each Legal Entity
            if (DateTime.Today.Month == 1)
                sp_CloseAccountingYear(SystemInformation.UserName, DateTime.Today.Year - 1);
        }
    }

    public abstract class DynamicAttributes
    {
        protected virtual IEnumerable<string> StaticAttributeNames()
        {
            return new string[0];
        }

        /// <summary>
        /// Return a list of attribute names prepended with the class name
        /// </summary>
        public virtual IEnumerable<string> AttributeNames()
        {
            List<string> attributeNames = new List<string>(StaticAttributeNames());

            string strType = this.GetType().ToString();

            DBADataContext dc = new DBADataContext();

            var attribs = from a in dc.Attributes
                          where a.AppliesTo.Equals(strType)
                          orderby a.Name
                          select string.Format("{0}.{1}", strType, a.Name);

            attributeNames.AddRange(attribs);

            attributeNames.Sort();

            return attributeNames;
        }

        public abstract Object AttributeValue(string name);

        public virtual Object AttributeValue(string name, Guid guid)
        {
            try
            {
                char[] delims = new char[] { '.' };
                DBADataContext dc = new DBADataContext();
                string[] parts = name.Split(delims);
                string attribName = this.GetType().Name;
                var resultValue = dc.fn_GetObjectAttributes(guid).First(delegate(fn_GetObjectAttributesResult r) { return r.Name.Equals(parts.Last()); });
                return resultValue.Value;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

    }

    public partial class RateMaster
    {
        /// <summary>
        /// The list of Rate Rules stored in the XML field
        /// </summary>
        private BindingList<RateRule> _RateRules;

        /// <summary>
        /// Lazy-loading Rate Rules, populated from the XML field
        /// </summary>
        public BindingList<RateRule> RateRules
        {
            get
            {
                if (XML == null)
                {
                    _RateRules = new BindingList<RateRule>();
                }
                else
                {
                    _RateRules = XMLUtility.DeserializeObject<BindingList<RateRule>>(this.XML);
                }
                _RateRules.ListChanged += new ListChangedEventHandler(_RateRules_ListChanged);
                return _RateRules;
            }
        }

        /// <summary>
        /// Update the XML field whenever the underlying list, or its attribute members, change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RateRules_ListChanged(object sender, ListChangedEventArgs e)
        {
            XML = XMLUtility.SerializeObject(_RateRules);
        }
    }

    public partial class LegalEntity : DynamicAttributes
    {
        protected override IEnumerable<string> StaticAttributeNames()
        {
            return new string[1] { "DowntownBoiseAssociation.LegalEntity.Exempt" };
        }

        public override object AttributeValue(string name)
        {
            switch (name)
            {
                case "DowntownBoiseAssociation.LegalEntity.Exempt":
                    return 0;
                default:
                    return base.AttributeValue(name, Guid);
            }
        }
    }

    public partial class Building : DynamicAttributes
    {
        public override object AttributeValue(string name)
        {
            return base.AttributeValue(name, this.Guid.Value);
        }
    }

    public partial class Tenant : DynamicAttributes
    {

        protected override IEnumerable<string> StaticAttributeNames()
        {
            return new string[1] { "DowntownBoiseAssociation.Tenant.Votes" };
        }

        public override object AttributeValue(string name)
        {
            switch (name)
            {
                case "DowntownBoiseAssociation.Tenant.Votes":
                    return this.Votes;
                default:
                    return base.AttributeValue(name, Guid);
            }
        }
    }

    public partial class Space : DynamicAttributes
    {
        protected override IEnumerable<string> StaticAttributeNames()
        {
            return new string[3] { "DowntownBoiseAssociation.Space.SqFt", "DowntownBoiseAssociation.Space.Zone", "DowntownBoiseAssociation.Space.Annually" };
        }

        public int ZoneId
        {
            get { return this.Building.Block.ZoneId; }
        }

        public override object AttributeValue(string name)
        {
            switch (name)
            {
                case "DowntownBoiseAssociation.Space.Annually":
                    return 1;
                case "DowntownBoiseAssociation.Space.SqFt":
                    return this.SqFt;
                case "DowntownBoiseAssociation.Space.Zone":
                    return this.Building.Block.Zone.Name;
                default:
                    return base.AttributeValue(name, Guid.Value);
            }
        }
    }

    public partial class Invoice
    {
        public decimal TotalAmount
        {
            get
            {
                decimal value = 0;
                foreach (var item in InvoiceDetails)
                {
                    if (item.Amount.HasValue)
                        value += item.Amount.Value;
                }

                return value;
            }
        }
    }

    public partial class Address
    {
        public string AddressLine
        {
            get
            {
                List<string> value = new List<string>();
                if (StreetNumber.Length > 0) value.Add(StreetNumber);
                if (StreetDirection.Length > 0) value.Add(StreetDirection);
                if (StreetName.Length > 0) value.Add(StreetName);
                if (StreetSuffix.Length > 0) value.Add(StreetSuffix);
                if (StreetSuite.Length > 0) value.Add(string.Format("suite {0}", StreetSuite));
                return string.Join(" ", value.ToArray());
            }
        }
    }

}
