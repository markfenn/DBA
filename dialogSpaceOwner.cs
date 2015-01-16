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
    public partial class dialogSpaceOwner : Form
    {
        private DBADataContext dba = new DBADataContext();        
        private bool _ExistingSpaceOwner;
                
        private Space _Space = null;
        private SpaceOwner _SpaceOwner = null;
        private LegalEntity _LegalEntity = null;

        private int _SpaceOwnerId;        
        
        
        /// <summary>
        /// Constructor for the form
        /// </summary>        
        public dialogSpaceOwner(int SpaceOwnerId, int SpaceId)
        {
            InitializeComponent();
            _SpaceOwnerId = SpaceOwnerId;
            dtpStartDate.Value = DateTime.Today;

            if (SpaceOwnerId == 0)
            {
                _ExistingSpaceOwner = false;
                _Space = null;
                _SpaceOwner = null;

                this.Text = "Add a new Owner";
            }
            else
            {
                _ExistingSpaceOwner = true;

                FillForm();
                this.Text = "Edit Space Owner: " + _LegalEntity.Name;
            }

            _Space = (from a in dba.Spaces
                      where a.Id == SpaceId
                      select a).FirstOrDefault();
        }

        private void FillForm()
        {
            if (_ExistingSpaceOwner)
            {
                _SpaceOwner = (from a in dba.SpaceOwners
                               where a.Id == _SpaceOwnerId
                               select a).FirstOrDefault();

                if (_SpaceOwner != null)
                {
                    _LegalEntity = (from a in dba.LegalEntities
                                    where a.Id == _SpaceOwner.LegalEntityId
                                    select a).FirstOrDefault();

                    dtpStartDate.Value = _SpaceOwner.AsOfDate;
                    linkSpace.Text = _LegalEntity.Name;
                }
                else
                {
                    _ExistingSpaceOwner = false;

                    _ExistingSpaceOwner = false;
                    _Space = null;
                    _SpaceOwner = null;

                    this.Text = "Add a new Owner";
                }

            }            
        }
               

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void linkSpace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchLegalEntity NewLE = new dialogSearchLegalEntity();
            NewLE.ShowDialog();

            if (NewLE.LegalEntityId == 0) { return; }

            _LegalEntity = (from a in dba.LegalEntities
                            where a.Id == NewLE.LegalEntityId
                            select a).FirstOrDefault();

            linkSpace.Text = _LegalEntity.Name;            
        }
        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_LegalEntity == null)
            {
                MessageBox.Show("Please select a Legal Entity.");
                return;
            }

            DateTime TempDate;
            try
            {
                TempDate = (DateTime)dtpStartDate.Value;
            }
            catch
            {
                MessageBox.Show("Please enter a valid Start Date.");
                return;
            }
                        
            if (_ExistingSpaceOwner)
            {
                _SpaceOwner.AsOfDate = (DateTime)dtpStartDate.Value;
                _SpaceOwner.LegalEntityId = _LegalEntity.Id;
            }
            else
            {
                SpaceOwner NewSpaceOwner = new SpaceOwner
                {
                    AsOfDate = (DateTime)dtpStartDate.Value,
                    LegalEntityId = _LegalEntity.Id,
                    SpaceId = _Space.Id
                };

                dba.SpaceOwners.InsertOnSubmit(NewSpaceOwner);            
            }
            
            dba.SubmitChanges();
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
