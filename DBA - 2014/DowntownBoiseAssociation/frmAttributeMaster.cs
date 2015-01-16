using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DowntownBoiseAssociation.Controls;

namespace DowntownBoiseAssociation
{
    public partial class frmAttributeMaster : Form
    {
        DBADataContext dc;

        public frmAttributeMaster()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create and bind the gridview and the combobox columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttributeMaster_Load(object sender, EventArgs e)
        {
            dc = new DBADataContext();

            attributeBindingSource.DataSource = dc.Attributes;

            DataGridViewTextBoxColumn oCategory = (DataGridViewTextBoxColumn)dataGridView1.Columns[1];
            //oCategory.DataSource = (from c in dc.Attributes select c.Category).Distinct();

            DataGridViewComboBoxColumn oType = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            oType.DataSource = ListTypes();

            DataGridViewComboBoxColumn oAppliesTo = (DataGridViewComboBoxColumn)dataGridView1.Columns[3];
            oAppliesTo.DataSource = ListAppliesTo();
        }

        /// <summary>
        /// Return the types that are editable by our editors (except for enums) and
        /// all of our custom enumeration types as well.
        /// </summary>
        /// <returns>a bindable list of strings</returns>
        private IList<String> ListTypes()
        {
            List<String> list = new List<string>();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] typeArray = assembly.GetTypes();
            foreach (Type type in typeArray)
            {
                foreach (PropertyEditor attr in type.GetCustomAttributes(typeof(PropertyEditor), false))
                {
                    if ((!attr.ForType.IsEnum) & (attr.ForType != typeof(System.Object)))
                        list.Add(attr.ForType.ToString());
                }
            }

            typeArray = Program.DynamicAssembly.GetTypes();
            foreach (Type type in typeArray)
            {
                if (type.IsEnum)
                    list.Add(type.ToString());
            }
            list.Sort();
            return list;
        }

        /// <summary>
        /// Compare the name of the member function with the filter criteria.
        /// </summary>
        /// <param name="objMemberInfo"></param>
        /// <param name="objSearch"></param>
        /// <returns>True for a match</returns>
        public static bool DelegateToSearchCriteria(MemberInfo objMemberInfo, Object objSearch)
        {
            return (objMemberInfo.Name.ToString() == objSearch.ToString());
        }

        /// <summary>
        /// Find all the class names in our assembly containing a "Guid" property
        /// </summary>
        /// <returns>a bindable list of strings</returns>
        private IList<String> ListAppliesTo()
        {
            List<String> list = new List<string>();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] typeArray = assembly.GetTypes();
            foreach (Type type in typeArray)
            {
                MemberInfo[] minfo = type.FindMembers(
                    MemberTypes.Property,
                    BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance,
                    new MemberFilter(DelegateToSearchCriteria),
                    "Guid");
                if (minfo.Length > 0)
                    list.Add(type.ToString());
            }
            list.Sort();
            return list;
        }

        private void attributeBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to update data");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (dataGridView1.CurrentRow == null);
        }

    }
}
