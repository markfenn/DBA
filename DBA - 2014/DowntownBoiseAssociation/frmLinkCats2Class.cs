using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace DowntownBoiseAssociation
{
    public partial class frmLinkCats2Class : Form
    {
        DBADataContext dba = new DBADataContext();
        List<int> AddList = new List<int>();
        List<int> DelList = new List<int>();

        public frmLinkCats2Class()
        {
            InitializeComponent();
        }

        private void LinkCats2Class_Load(object sender, EventArgs e)
        {          
            LoadData();
        }

        private void LoadData()
        {
            
            classBindingSource.DataSource = from c in dba.Classes
                                            where ((c.IsActive == true) && (c.ClassType == "BUS"))
                                            orderby c.Name
                                            select c;

            CategoryBindingSource.DataSource = from a in dba.Categories
                                               where ((a.IsActive == true) && (a.CatType == "BUS"))
                                               orderby a.Name
                                               select a;
            SetChecks();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int iClassId = ((Class)cboClassFilter.SelectedItem).Id;

            // Add all of the new Categories

            foreach (int Item in AddList)
            {
                CatClass NewCatClass = new CatClass
                {
                    ClassId = iClassId,
                    CategoryId = Item
                };

                dba.CatClasses.InsertOnSubmit(NewCatClass);
                dba.SubmitChanges();
            }

            // Remove all of the deleted categories as well as from the TenantCatClass table
            //
            // The user was warned in the CellContentClick event about the delete from the
            // TenantCatClass table

            foreach (int Item in DelList)
            {
                // Get the CatClass record

                CatClass CurrentCatClass = (from a in dba.CatClasses
                                            where a.ClassId == iClassId &&
                                            a.CategoryId == Item
                                            select a).FirstOrDefault();

                // Get the TenantCatClass records if they(it) exist
                var CurrentTenantCatClass = from a in dba.TenantCatClasses
                                            where a.CatClassId == CurrentCatClass.Id
                                            select a;

                // If there are TenantCatClass records, delete them
                if (CurrentTenantCatClass.Count() > 0)
                {
                    dba.TenantCatClasses.DeleteAllOnSubmit(CurrentTenantCatClass);
                    dba.SubmitChanges();
                }

                // Now delete the CatClassRecord
                dba.CatClasses.DeleteOnSubmit(CurrentCatClass);
                dba.SubmitChanges();
            }

            SetChecks();

            AddList.Clear();
            DelList.Clear();

            MessageBox.Show("Save Complete.");
        }
              

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
               

        private void cboClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetChecks();

            AddList.Clear();
            DelList.Clear();
        }

        private void SetChecks()
        {
            Class ClassObject = (Class)cboClassFilter.SelectedItem;

            if (ClassObject == null) return;

            var SelectedItems = from a in dba.CatClasses
                                join b in dba.Categories
                                on a.CategoryId equals b.Id
                                join c in dba.Classes
                                on a.ClassId equals c.Id
                                where a.ClassId == ClassObject.Id
                                select new {
                                a.Id,
                                ClassName = c.Name,
                                CategoryName = b.Name
                                };

            DataGridViewCellStyle DefaultStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle NewStyle = new DataGridViewCellStyle();
            NewStyle.BackColor = System.Drawing.Color.Salmon;

            foreach (DataGridViewRow Item in dataGridView1.Rows)
            {
                Item.Cells[1].Value = false;
                Item.Cells[0].Style = DefaultStyle;
                Item.Cells[1].Style = DefaultStyle;

                foreach (var SubItem in SelectedItems)
                {
                    if (Item.Cells[0].Value != null)
                    {
                        if (Item.Cells[0].Value.ToString().Trim().ToUpper() == SubItem.CategoryName.Trim().ToUpper())
                        {                            
                            Item.Cells[0].Style = NewStyle;
                            Item.Cells[1].Style = NewStyle;
                            Item.Cells[1].Value = true;
                        }
                    }
                }
            }
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iClassId = ((Class)cboClassFilter.SelectedItem).Id;
            bool iChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;

            //MessageBox.Show(iChecked.ToString());

            dataGridView1.Rows[e.RowIndex].Cells[0].Selected = true;

            Category ItemCategory = (Category)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            CatClass CatClassItem = (from a in dba.CatClasses
                                    where (a.ClassId == iClassId) &&
                                    (a.CategoryId == ItemCategory.Id)
                                    select a).FirstOrDefault();

            if (CatClassItem != null)
            {
                var TenantCatClassItems = from a in dba.TenantCatClasses
                                                    where a.CatClassId == CatClassItem.Id
                                                    select a;

                if (TenantCatClassItems != null)
                {
                    // If the item is being unchecked (deleted) and there are records
                    // in the TenantCatClass Table then give a warning
                    if ((iChecked) && (TenantCatClassItems.Count() > 0))
                    {
                        if (MessageBox.Show("There are " + TenantCatClassItems.Count().ToString() + " Tenants with this Class and Category, " +
                        "if you unselect this item it will be removed from these existing Tenants when Apply is selected. \r\n\r\n" +
                        "Do you wish to continue?", "Tenant Class Category Change",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[1].Value = true;
                            return;
                        }                    
                    }
                    
                    MaintList(iChecked, ItemCategory.Id);

                }
                else
                {
                    MaintList(iChecked, ItemCategory.Id);
                }
            }
            else
            {
                MaintList(iChecked, ItemCategory.Id);
            }            
        }

        private void MaintList(bool CheckStatus, int ItemId)
        {
            bool DidRemove;

            if (CheckStatus)
            {
                // The item was checked and is now being unchecked

                // See if it was first put into the Add List (and remove it)
                DidRemove = AddList.Remove(ItemId);

                // If it was not in the Add List, then put it in the Del List
                if (!DidRemove) DelList.Add(ItemId);
            }
            else
            {
                // The item was unchecked and is now being checked

                // See if it was first put into the Del List (and remove it)
                DidRemove = DelList.Remove(ItemId);

                // If it was not in the Del List, then put it in the Add List
                if (!DidRemove) AddList.Add(ItemId);                
            }
        }
    }
}
