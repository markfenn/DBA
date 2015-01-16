using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation
{
    public partial class dialogClassCategorySelector : Form
    {
        DBADataContext dba = new DBADataContext();
        private int _TenantId = 0;
        private int _TenantCatClassId = 0;

        public dialogClassCategorySelector(int TenantId)
        {
            InitializeComponent();
            _TenantId = TenantId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _TenantCatClassId = 0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dialogClassCategorySelector_Load(object sender, EventArgs e)
        {
            FillClassDropDown();
            ddlClass.SelectedIndex = 0;
        }

        private void FillClassDropDown()
        {
            var ClassList = (from a in dba.CatClasses
                           join b in dba.Classes
                           on a.ClassId equals b.Id
                           orderby b.Name                           
                           select new
                           {
                               a.ClassId,
                               b.Name
                           }).Distinct();
            
            foreach(var Item in ClassList)
            {
                Classes.SearchList NewSearch = new Classes.SearchList();
                NewSearch.SearchText = Item.Name;
                NewSearch.Id = Item.ClassId;
                
                ddlClass.Items.Add(NewSearch);
                ddlClass.DisplayMember = "SearchText";    
            }            
        }

        private void FillCategoryDropDown(int inClassId)
        {
            ddlCategory.Items.Clear();

            var CategoryList = (from a in dba.CatClasses
                                join b in dba.Categories
                                on a.CategoryId equals b.Id
                                orderby b.Name
                                where a.ClassId == inClassId
                                select new
                                {
                                    a.CategoryId,
                                    b.Name
                                }).Distinct();

            foreach (var Item in CategoryList)
            {
                Classes.SearchList NewSearch = new Classes.SearchList();
                NewSearch.SearchText = Item.Name;
                NewSearch.Id = Item.CategoryId;

                ddlCategory.Items.Add(NewSearch);
                ddlCategory.DisplayMember = "SearchText";
            }

            ddlCategory.SelectedIndex = 0;
        }

        private void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.SearchList NewItem = (Classes.SearchList)ddlClass.SelectedItem;
            FillCategoryDropDown(NewItem.Id);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Classes.SearchList NewClass = (Classes.SearchList)ddlClass.SelectedItem;
            Classes.SearchList NewCategory = (Classes.SearchList)ddlCategory.SelectedItem;

            int _CatClassId = (from a in dba.CatClasses
                               where ((a.CategoryId == NewCategory.Id) && (a.ClassId == NewClass.Id))
                               select a.Id).FirstOrDefault();

            // Is it already in the list?
            int _Count = (from a in dba.TenantCatClasses
                          where ((a.TenantId == _TenantId) && (a.CatClassId == _CatClassId))
                          select a.Id).FirstOrDefault();

            if (_Count > 0)
            {
                MessageBox.Show("This already exists, please select another.");
                return;
            }

            TenantCatClass NewItem = new TenantCatClass
            {
                CatClassId = _CatClassId,
                TenantId = _TenantId
            };

            dba.TenantCatClasses.InsertOnSubmit(NewItem);
            dba.SubmitChanges();

            _TenantCatClassId = NewItem.Id;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        public int TenantCatClassId
        {
            get { return _TenantCatClassId; }
        }
    }
}
