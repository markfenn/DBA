using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DowntownBoiseAssociation
{
    public partial class reportBlockPersonsContactingInfo : Form
    {
        private DBADataContext dba = new DBADataContext();

        private List<int> indeciesForRemovedItems;
        private List<int> _selectedBlocks = new List<int>();
        private List<int> _blockIds;
        private List<int[]> _blockInfo;
        private String selectedInfo = "";
        private String selectedEntities = "";

        private List<vw_ContactingInformationByBlockId> contactingInfo;
        private List<vw_TenantContactsByBlockId> tenantContacts;

        private int _SelectId;
        private string _SelectName;

        public List<int> SelectedBlocks 
        {
            get { return _selectedBlocks; }
            set
            {
                _selectedBlocks = value;
                indeciesForRemovedItems = new List<int>();
                lvwToBeSaved.Items.Clear();
                lvwRemoved.Items.Clear();
                LoadBlockInfo();
            }
        }

        public reportBlockPersonsContactingInfo()
        {
            InitializeComponent();
            indeciesForRemovedItems = new List<int>();
            _blockIds = new List<int>();
            _blockInfo = new List<int[]>();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxesSelected() && blockesSelected())
            {
                tclRequestedInformation.Visible = true;
            }
            else
            {
                tclRequestedInformation.Visible = false;
            }
        }

        private Boolean contactInfoToGatherChanged()
        {
            String temp = "";
            if (cbxEmail.Checked){temp = temp + "1";}
            if (cbxPhone.Checked){temp = temp + "2";}
            if (cbxAddress.Checked){temp = temp + "3";}

            String temp2 = "";
            if (cbxBillTo.Checked){temp2 = temp2 + "1";} 
            if (cbxBlockCaptains.Checked){temp2 = temp2 + "2";}
            if (cbxContacts.Checked){temp2 = temp2 + "3";}
            if (cbxSpaceOwners.Checked){temp2 = temp2 + "4";}
            if (cbxTenants.Checked) { temp2 = temp2 + "5"; }

            if (!temp2.Equals(selectedEntities))
            {
                indeciesForRemovedItems.Clear();
                selectedEntities = temp2;
                lvwToBeSaved.Items.Clear();
                lvwRemoved.Items.Clear();                
            }

            if (temp.Equals(selectedInfo))
                return false;

            selectedInfo = temp;
            lvwToBeSaved.Items.Clear();
            lvwRemoved.Items.Clear();  
            return true;
        }

        private Boolean checkBoxesSelected()
        {
            Boolean info;
            Boolean whoWhat;

            if (contactInfoToGatherChanged())
            {
                lvwToBeSaved.Columns.Clear();
                lvwRemoved.Columns.Clear();
                lvwToBeSaved.Columns.Add("Name", 150, HorizontalAlignment.Left);
                lvwRemoved.Columns.Add("Name", 150, HorizontalAlignment.Left);
                if (cbxEmail.Checked)
                {
                    lvwToBeSaved.Columns.Add("Email", 100, HorizontalAlignment.Left);
                    lvwRemoved.Columns.Add("Email", 100, HorizontalAlignment.Left);
                }
                if (cbxPhone.Checked)
                {
                    lvwToBeSaved.Columns.Add("Phone", 80, HorizontalAlignment.Center);
                    lvwRemoved.Columns.Add("Phone", 80, HorizontalAlignment.Center);
                }
                if (cbxAddress.Checked)
                {
                    lvwToBeSaved.Columns.Add("Address", 225, HorizontalAlignment.Left);
                    lvwRemoved.Columns.Add("Address", 225, HorizontalAlignment.Left);
                }
                lvwToBeSaved.Columns.Add("Block #", 60, HorizontalAlignment.Center);
                lvwRemoved.Columns.Add("Block #", 60, HorizontalAlignment.Center);
                lvwToBeSaved.Columns.Add("Type", 100, HorizontalAlignment.Left);
                lvwRemoved.Columns.Add("Type", 100, HorizontalAlignment.Left);
                lvwToBeSaved.Columns.Add("ContactName", 150, HorizontalAlignment.Left);
                lvwRemoved.Columns.Add("ContactName", 150, HorizontalAlignment.Left);
                lvwToBeSaved.View = View.Details;
                lvwToBeSaved.AllowColumnReorder = true;
                lvwRemoved.View = View.Details;
                lvwRemoved.AllowColumnReorder = true;
            }

            info = cbxAddress.Checked || cbxEmail.Checked || cbxPhone.Checked;
            whoWhat = cbxBillTo.Checked || cbxBlockCaptains.Checked || cbxContacts.Checked || cbxSpaceOwners.Checked || cbxTenants.Checked;

            return (info && whoWhat);
        }

        private Boolean blockesSelected()
        {
            return (lbxBlocksSelected.Visible && lbxBlocksSelected.Items.Count > 0);
        }

        private List<vw_ContactingInformationByBlockId> getContactingInfo()
        {
            if (contactingInfo != null && contactingInfo.Count > 0)
                return contactingInfo;

            var dataList = (from p in dba.vw_ContactingInformationByBlockIds
                            where _blockIds.Contains(p.BlockId.Value)
                            orderby p.Name, p.itemType
                            select p);
            contactingInfo = new List<vw_ContactingInformationByBlockId>();
            foreach(vw_ContactingInformationByBlockId v in dataList)
            {
                contactingInfo.Add(v);
            }

            var dataList2 = (from p in dba.vw_TenantContactsByBlockIds
                             where _blockIds.Contains(p.BlockId.Value)
                             orderby p.ContactName, p.BlockId
                             select p);

            tenantContacts = new List<vw_TenantContactsByBlockId>();
            foreach (vw_TenantContactsByBlockId b in dataList2)
            {
                tenantContacts.Add(b);
            }

            return contactingInfo;
        }

        private List<vw_ContactingInformationByBlockId> LimitContactingInfo(List<vw_ContactingInformationByBlockId> fullDataList)
        {
            List<String> entitiesToLookAt = new List<string>();

            if(cbxBillTo.Checked) 
                entitiesToLookAt.Add("BillTo");
            if (cbxBlockCaptains.Checked)
                entitiesToLookAt.Add("BlockCaptain");
            if (cbxContacts.Checked)
                entitiesToLookAt.Add("Contact");
            if (cbxSpaceOwners.Checked)
                entitiesToLookAt.Add("SpaceOwner");
            if (cbxTenants.Checked)
                entitiesToLookAt.Add("Tenant");

            var limitedDataList = from l in fullDataList
                                  where entitiesToLookAt.Contains(l.itemType)
                                  orderby l.Name, l.itemType
                                  select l;

            List<vw_ContactingInformationByBlockId> reObject = new List<vw_ContactingInformationByBlockId>();
            foreach (vw_ContactingInformationByBlockId v in limitedDataList)
            {
                reObject.Add(v);
            }

            return reObject;
        }
        
        private void LoadContactingInfo()
        {
            lvwToBeSaved.Items.Clear();
            lvwRemoved.Items.Clear();

            var dataList = LimitContactingInfo(getContactingInfo());

            int index = 0;
            Boolean removedItemFlag;
            lvwToBeSaved.BeginUpdate();
            lvwRemoved.BeginUpdate();
            ListViewItem reportListItem;
            int blockNumber;
            foreach (var Item in dataList)
            {
                reportListItem = new ListViewItem();
                removedItemFlag = false;
                blockNumber = _blockInfo.FirstOrDefault(b => b[0] == Item.BlockId)[1];
                //blockNumber = dba.Blocks.FirstOrDefault(b => b.Id == Item.BlockId).BlockNumber;
                foreach (var removedItem in indeciesForRemovedItems)
                {
                    if (removedItem == index)
                    {
                        if(String.IsNullOrEmpty(Item.Name))
                            reportListItem.Text = " - ";
                        else
                            reportListItem.Text = Item.Name;
                        reportListItem.Tag = index;
                        if (cbxEmail.Checked)
                            reportListItem.SubItems.Add(Item.Email);
                        if (cbxPhone.Checked)
                            reportListItem.SubItems.Add(Item.Phone);
                        if (cbxAddress.Checked)
                        {
                            if (Item.AddressId.Value < 1)
                                reportListItem.SubItems.Add("");
                            else
                            {
                                reportListItem.SubItems.Add(Item.FullAddress);
                            }
                        }
                        reportListItem.SubItems.Add(blockNumber.ToString());
                        reportListItem.SubItems.Add(Item.itemType);

                        var dataContact = from a in tenantContacts
                                          where a.SpaceId == Item.SpaceId
                                          orderby a.ContactName, a.Description
                                          select a;
                        String contactNames = "";
                        int counter = 1;
                        foreach (var i in dataContact)
                        {
                            contactNames = contactNames + i.ContactName;
                            if (counter < dataContact.Count())
                                contactNames = contactNames + ", ";
                        }

                        if (String.IsNullOrEmpty(contactNames))
                            contactNames = "N/A";
                        reportListItem.SubItems.Add(contactNames);
                        lvwRemoved.Items.Add(reportListItem);

                        removedItemFlag = true;
                        break;
                    }
                }

                if (!removedItemFlag)
                {
                    if (String.IsNullOrEmpty(Item.Name))
                        reportListItem.Text = " - ";
                    else
                        reportListItem.Text = Item.Name;
                    reportListItem.Tag = index;
                    if (cbxEmail.Checked)
                        reportListItem.SubItems.Add(Item.Email);
                    if (cbxPhone.Checked)
                        reportListItem.SubItems.Add(Item.Phone);
                    if (cbxAddress.Checked)
                    {
                        if (Item.AddressId.Value < 1)
                            reportListItem.SubItems.Add("");
                        else
                        {
                            reportListItem.SubItems.Add(Item.FullAddress);
                        }
                    }
                    
                    reportListItem.SubItems.Add(blockNumber.ToString());
                    reportListItem.SubItems.Add(Item.itemType);

                    var dataContact = from a in tenantContacts
                                      where a.SpaceId == Item.SpaceId
                                      orderby a.ContactName, a.Description
                                      select a;
                    String contactNames = "";
                    int counter = 1;
                    foreach (var i in dataContact)
                    {
                        contactNames = contactNames + i.ContactName;
                        if (counter < dataContact.Count())
                            contactNames = contactNames + ", ";
                    }

                    if (String.IsNullOrEmpty(contactNames))
                        contactNames = reportListItem.Text;
                    reportListItem.SubItems.Add(contactNames);
                    lvwToBeSaved.Items.Add(reportListItem);
                }

                index++;
            }
            lvwRemoved.EndUpdate();
            lvwToBeSaved.EndUpdate();
        }

        private void LoadBlockInfo()
        {
            lbxBlocksSelected.Items.Clear();
            _blockIds = new List<int>();
            indeciesForRemovedItems.Clear();

            var dataList = from b in dba.Blocks
                           where SelectedBlocks.Contains(b.BlockNumber)
                           orderby b.BlockNumber
                           select b;
            int[] tempHolder;
            foreach (var Item in dataList)
            {
                tempHolder = new int[2];
                Classes.SearchList NewAdd = new Classes.SearchList();

                if (Item.Name.Equals(Item.BlockNumber.ToString()))
                    NewAdd.SearchText = Item.Name;
                else
                    NewAdd.SearchText = Item.BlockNumber.ToString() + ", " + Item.Name;

                NewAdd.Id = Item.BlockNumber;

                _blockIds.Add(Item.Id);
                tempHolder[0] = Item.Id;
                tempHolder[1] = Item.BlockNumber;
                _blockInfo.Add(tempHolder);

                lbxBlocksSelected.DisplayMember = "SearchText";
                lbxBlocksSelected.Items.Add(NewAdd);
            }

            if (dataList != null && dataList.Count() > 0)
            {
                lbxBlocksSelected.Visible = true;
                lblBlocksSelectedYesNo.Text = "Yes";
            }
            else
            {
                lbxBlocksSelected.Visible = false;
                lblBlocksSelectedYesNo.Text = "No";
            }
        }

        private void btnSelectBlocks_Click(object sender, EventArgs e)
        {
            frmBlockSelector NewListForm = new frmBlockSelector(SelectionType.Block, false, false);
            NewListForm.ShowDialog();
            if (NewListForm.DialogResult == DialogResult.OK)
            {
                SelectedBlocks = NewListForm.SelectedObjects;
                if (checkBoxesSelected() && blockesSelected())
                    tclRequestedInformation.Visible = true;
                else
                    tclRequestedInformation.Visible = false;
                contactingInfo = new List<vw_ContactingInformationByBlockId>();
            }
            NewListForm.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvwToBeSaved != null && lvwToBeSaved.Items.Count > 0)
            {
                if (Classes.SaveListViewToFile.SaveThisListViewToFile(lvwToBeSaved))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("  At least one checkbox in the Information group and one checkbox in the Persons of Interest group must be checked.  Also, Block(s) must be selected.  There must also be items in the Requested list.");
                return;
            }
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            if (checkBoxesSelected() && blockesSelected())
            {
                Cursor thisCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                LoadContactingInfo();
                Cursor.Current = thisCursor;
            }
            else
            {
                MessageBox.Show("  At least one checkbox in the Information group and one checkbox in the Persons of Interest group must be checked.  Also, Block(s) must be selected.");
                return;
            }
        }

        private void resortListView(ListView thisView)
        {
            ListView.ListViewItemCollection lvCollection = new ListView.ListViewItemCollection( thisView);

            List<ListViewItem> tempLVList = new List<ListViewItem>();
            foreach (ListViewItem item in lvCollection)
            {
                tempLVList.Add(item);
            }

            thisView.Items.Clear();

            var newLV = from c in tempLVList
                        orderby c.Text, c.SubItems[c.SubItems.Count - 1].Text
                        select c;
            thisView.Update();
            foreach (ListViewItem lvi in newLV)
                thisView.Items.Add(lvi);
            thisView.EndUpdate();
        }

        private void moveEntityToRemovedList(int index)
        {
            foreach (ListViewItem item in lvwToBeSaved.Items)
            {
                if (((int)item.Tag) == index)
                {
                    lvwToBeSaved.Items.Remove(item);
                    lvwRemoved.Items.Add(item);
                    indeciesForRemovedItems.Add((int)item.Tag);
                    break;
                }
            }
            resortListView(lvwRemoved);
        }

        private void restoreEntityToSaveList(List<int> indexList)
        {
            foreach (int index in indexList)
            {
                foreach (ListViewItem item in lvwRemoved.Items)
                {
                    if (((int)item.Tag) == index)
                    {
                        lvwRemoved.Items.Remove(item);
                        lvwToBeSaved.Items.Add(item);
                        indeciesForRemovedItems.Add((int)item.Tag);
                        break;
                    }
                }
            }
            resortListView(lvwToBeSaved);
        }

        private void editThisItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbxBlocksSelected.Focused)
            {
                lvwToBeSaved.Items.Clear();
                lvwRemoved.Items.Clear();

                List<int> newBlockList = new List<int>();
                foreach (int i in SelectedBlocks)
                {
                    if (_SelectId != i)
                        newBlockList.Add(i);
                }
                SelectedBlocks = newBlockList;
                contactingInfo = new List<vw_ContactingInformationByBlockId>();
            }
            else if (tclRequestedInformation.SelectedTab.Text.Equals("Removed") && lvwRemoved.Focused)
            {
                List<int> thisList = new List<int>();
                thisList.Add(_SelectId);
                restoreEntityToSaveList(thisList);
            }
            else if (tclRequestedInformation.SelectedTab.Text.Equals("Requested") && lvwToBeSaved.Focused)
            {
                moveEntityToRemovedList(_SelectId);
            }
        }

        private void menuRelationship_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if(lbxBlocksSelected.Focused)
                {
                    _SelectId = ((Classes.SearchList)lbxBlocksSelected.SelectedItem).Id;
                    _SelectName = ((Classes.SearchList)lbxBlocksSelected.SelectedItem).SearchText;

                    menuRelationship.Items[0].Text = "Remove Block: " + _SelectName;
                    menuRelationship.Items[1].Visible = true;
                    menuRelationship.Items[1].Text = "Edit Block List";
                }
                else if (tclRequestedInformation.SelectedTab.Text.Equals("Requested") && lvwToBeSaved.Focused)
                {
                    _SelectId = Convert.ToInt32(((ListViewItem)lvwToBeSaved.SelectedItems[0]).Tag);
                    _SelectName = ((ListViewItem)lvwToBeSaved.SelectedItems[0]).Text;

                    menuRelationship.Items[0].Text = "Remove: " + _SelectName;
                    menuRelationship.Items[1].Visible = false;
                }
                else if (tclRequestedInformation.SelectedTab.Text.Equals("Removed") && lvwRemoved.Focused)
                {
                    _SelectId = Convert.ToInt32(((ListViewItem)lvwRemoved.SelectedItems[0]).Tag);
                    _SelectName = (string)((ListViewItem)lvwRemoved.SelectedItems[0]).Text;

                    menuRelationship.Items[0].Text = "Restore: " + _SelectName;
                    menuRelationship.Items[1].Visible = true;
                    menuRelationship.Items[1].Text = "Restore All";
                }
                else
                {
                    _SelectId = 0;
                    _SelectName = "";
                }
            }
            catch (Exception ex)
            {
                _SelectName = "";
                _SelectId = 0;
            }

            if (_SelectName == "") { e.Cancel = true; }
        }

        private void editThisItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbxBlocksSelected.Focused)
            {
                frmBlockSelector NewListForm = new frmBlockSelector(SelectionType.Block, false, false);
                NewListForm.SelectedObjects = SelectedBlocks;
                NewListForm.ShowDialog();
                if (NewListForm.DialogResult == DialogResult.OK)
                {
                    SelectedBlocks = NewListForm.SelectedObjects;
                    if (checkBoxesSelected() && blockesSelected())
                        tclRequestedInformation.Visible = true;
                    else
                        tclRequestedInformation.Visible = false;
                    contactingInfo = new List<vw_ContactingInformationByBlockId>();
                }
                NewListForm.Dispose();
            }
            else if (tclRequestedInformation.SelectedTab.Text.Equals("Removed") && lvwRemoved.Focused)
            {
                List<int> thisList = new List<int>();
                foreach (ListViewItem lvi in lvwRemoved.Items)
                    thisList.Add((int)lvi.Tag);
                restoreEntityToSaveList(thisList);
            }
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView thisView = (sender as ListView);

            ListView.ListViewItemCollection lvCollection = new ListView.ListViewItemCollection(thisView);
            List<ListViewItem> tempLVList = new List<ListViewItem>();

            foreach (ListViewItem item in lvCollection)
                tempLVList.Add(item);

            thisView.Items.Clear();

            var newLV = from c in tempLVList
                        orderby c.SubItems[e.Column].Text
                        select c;

            thisView.Update();
            foreach (ListViewItem lvi in newLV)
                thisView.Items.Add(lvi);
            thisView.EndUpdate();
        }

        
    }
}
