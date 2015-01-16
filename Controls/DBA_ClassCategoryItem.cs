using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    public partial class DBA_ClassCategoryItem : UserControl
    {
        private DBADataContext dba = new DBADataContext();

        private int _TenantId = 0;

        public DBA_ClassCategoryItem()
        {
            InitializeComponent();
        }

        private void DBA_ClassCategoryItem_Resize(object sender, EventArgs e)
        {

        }

        public int TenantId
        {
            get { return _TenantId; }
            set
            {
                _TenantId = value;
                GetClassesAndCategories(_TenantId);
            }
        }

        private void GetClassesAndCategories(int TenantId)
        {
            lvClassCategory.Items.Clear();

            var Classes = from a in dba.TenantCatClasses
                          join b in dba.CatClasses
                          on a.CatClassId equals b.Id
                          join c in dba.Classes
                          on b.ClassId equals c.Id
                          join d in dba.Categories
                          on b.CategoryId equals d.Id
                          where a.TenantId == TenantId
                          select new 
                          {
                              a.Id,
                              a.TenantId,
                              ClassName = c.Name,
                              CategoryName = d.Name
                          };

            if (Classes.Count() == 0) { return; }

            foreach (var Item in Classes)
            {
                string[] Cols = new string[3];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.ClassName;
                Cols[2] = Item.CategoryName;
                
                ListViewItem NewItem = new ListViewItem(Cols);
                lvClassCategory.Items.Add(NewItem);                
            }
        }
            

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvClassCategory.Items.Count == 0)
            {
                MessageBox.Show("You must select an item in the list.");
                return;
            }

            if (MessageBox.Show("Are you sure you wish to delete this item?","Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int SelectedId = Convert.ToInt32(lvClassCategory.SelectedItems[0].SubItems[0].Text);
            TenantCatClass DelItem = (from a in dba.TenantCatClasses
                                      where a.Id == SelectedId
                                      select a).FirstOrDefault();

            dba.TenantCatClasses.DeleteOnSubmit(DelItem);
            dba.SubmitChanges();

            GetClassesAndCategories(_TenantId);
        }

        private void DBA_ClassCategoryItem_Leave(object sender, EventArgs e)
        {            
            btnDelete.Enabled = false;
        }

        private void lvClassCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClassCategory.SelectedItems.Count == 0)
            {                
                btnDelete.Enabled = false;
            }
        }

        private void lvClassCategory_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dialogClassCategorySelector NewForm = new dialogClassCategorySelector(_TenantId);
            NewForm.ShowDialog();

            if (NewForm.TenantCatClassId == 0) { return; }

            GetClassesAndCategories(_TenantId);
        }
               
    }
}
