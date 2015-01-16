using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Remoting;

namespace DowntownBoiseAssociation.Controls
{
    public partial class editProperties : UserControl
    {
        public editProperties()
        {
            InitializeComponent();
        }

        private Guid _objectGuid;
        private List<string> _DisplayGroups = new List<string>();
        private List<string> _NonDisplayGroups = new List<string>();

        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> DisplayGroups
        {
            get { return _DisplayGroups; }
            set { _DisplayGroups = value; }
        }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> NonDisplayGroups
        {
            get { return _NonDisplayGroups; }
            set { _NonDisplayGroups = value; }
        }
        
        [Bindable(BindableSupport.Yes)]
        public Guid ObjectGuid
        {
            set
            {
                _objectGuid = value;
                CreateEditors(value);
            }
        }

        System.Collections.Generic.Dictionary<Type, Type> _UIControls;

        private bool IsInGroups(string Value)
        {
            if (_DisplayGroups.Count == 0) { return true; }

            foreach (string Item in _DisplayGroups)
            {
                if (Item.Trim().ToUpper() == Value.Trim().ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsInNonGroups(string Value)
        {
            if (_NonDisplayGroups.Count == 0) { return false; }

            foreach (string Item in _NonDisplayGroups)
            {
                if (Item.Trim().ToUpper() == Value.Trim().ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        private System.Collections.Generic.Dictionary<Type, Type> UIControls
        {
            get
            {
                if (_UIControls == null)
                {
                    _UIControls = new Dictionary<Type, Type>();

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type[] typeArray = assembly.GetTypes();
                    foreach (Type type in typeArray)
                    {
                        foreach (PropertyEditor attr in type.GetCustomAttributes(typeof(PropertyEditor), false))
                        {
                            _UIControls.Add(attr.ForType, type);
                        }
                    }
                }
                return _UIControls;
            }
        }

        private Control FindEditControl(Type aType)
        {
            Type ui = null;
            try
            {
                ui = UIControls[aType];
            }
            catch (KeyNotFoundException e)
            {
                foreach (Type t in UIControls.Keys)
                {
                    //The derived classes all come in as system.enum, but depending on how .net is feeling
                    //it can order the list with system.object first or last. This is important because the
                    //derived classes are also a system.object. If the derived classes use the system.object
                    //then the editBase editor is used (which is what you don't want). If it is coming in first
                    //then comment out the break command, if last then uncomment it.
                    if (aType.IsSubclassOf(t))
                    {
                        ui = UIControls[t];
                        //break;
                    }
                }
                if (ui == null) return new EditBase();
            }

            Control tmp = (Control)Activator.CreateInstance(ui);
            (tmp as IPropertyUserInterface).DataType = aType;
            return tmp;
        }

        private void CreateEditors(Guid objectGuid)
        {
            this.SuspendLayout();
            try
            {
                this.flowEdit.Controls.Clear();

                DBADataContext dc = new DBADataContext();

                var attributes = from a in dc.fn_GetObjectAttributes(objectGuid)
                                 orderby a.Category, a.Name descending
                                 select a;

                GroupBox gb = null;
                int gbHeight = 0;
                int itemTabIndex = 1000;
                foreach (var attr in attributes)
                {
                    if (IsInGroups(attr.Category) && !IsInNonGroups(attr.Category))
                    {
                        if ((gb == null) || (!gb.Text.Equals(attr.Category)))
                        {
                            gb = new GroupBox();
                            this.flowEdit.Controls.Add(gb);
                            gb.Text = attr.Category;
                            gb.Dock = DockStyle.Top;
                            gb.Width = 300;
                            gbHeight = 0;
                            itemTabIndex = 100;
                        }

                        Type t = Type.GetType(attr.Type);
                        if (t == null)
                        {
                            ObjectHandle oh = Activator.CreateInstance("DowntownBoiseAssociation.ClassCategories", attr.Type);
                            t = oh.Unwrap().GetType();
                        }

                        Control eb = FindEditControl(t);

                        gb.Controls.Add(eb);
                        eb.TabIndex = itemTabIndex--;
                        eb.Parent = gb;
                        IPropertyUserInterface ui = eb as IPropertyUserInterface;
                        ui.PropertyId = attr.Id.Value;
                        ui.Label = attr.Name;
                        ui.Value = attr.Value;
                        eb.Dock = DockStyle.Top;
                        gbHeight += eb.Height;
                        gb.Height = gbHeight + 25;
                    }
                }

                foreach (GroupBox g in this.flowEdit.Controls)
                {
                    //g.AutoSize = true;
                }
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        public void SaveChanges()
        {
            DBADataContext dc = new DBADataContext();
            foreach (Control grp in this.flowEdit.Controls)
                foreach (Control ctl in grp.Controls)
                {
                    if (ctl is IPropertyUserInterface)
                    {
                        IPropertyUserInterface ui = ctl as IPropertyUserInterface;
                        if (ui != null)
                            dc.insUpdObjectAttributeValue(_objectGuid, ui.PropertyId, ui.Value);
                    }
                }
            dc.SubmitChanges();
        }


    }
       
}
