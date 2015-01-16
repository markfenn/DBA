using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace DowntownBoiseAssociation
{
    public partial class frmPerformBilling : Form
    {
        private View[] ValidViewValues = { View.Details, View.LargeIcon, View.List, View.SmallIcon };

        public frmPerformBilling()
        {
            InitializeComponent();
        }

        DBADataContext dc = new DBADataContext();
        IQueryable<Space> spaces;
        List<Invoice> invoices = new List<Invoice>();
        InvoiceWorker worker;
        ProgressChangedEventHandler progressChangedEventHandler;
        RunWorkerCompletedEventHandler runWorkerCompletedEventHandler;
        SpaceChangedEventHandler OnSpaceChangedEventHandler;
        int ItemCounter = 0;
        int SpacesCount = 0;

        private void frmPerformBilling_Shown(object sender, EventArgs e)
        {
            dialogPerformBilling dlg = new dialogPerformBilling();
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                CreateViewMenu(btnView);

                switch (dlg.ProcessingType)
                {
                    case ProcessingType.All:
                        spaces = from s in dc.Spaces
                                 select s;
                        break;
                    case ProcessingType.LegalEntity:
                        spaces = dc.fn_GetLegalEntitySpaces(dlg.LegalEntityId, dlg.Year);
                        break;
                    case ProcessingType.SelectedSpace:
                        spaces = from s in dc.Spaces
                                 where s.AddressId.Equals(dlg.AddressId)
                                 select s;
                        break;
                }

                SpacesCount = spaces.Count();
               

                CreateBillingInvoices(spaces, dlg.Year);
            }
        }

        private void CreateBillingInvoices(IQueryable<Space> spaces, int year)
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 1;

            worker = new InvoiceWorker(dc, spaces, invoices, year);
            // hang onto references of event handlers so we can remove them later
            progressChangedEventHandler = new ProgressChangedEventHandler(worker_ProgressChanged);
            runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            OnSpaceChangedEventHandler = new SpaceChangedEventHandler(worker_OnSpaceChanged);

            worker.ProgressChanged += progressChangedEventHandler;
            worker.RunWorkerCompleted += runWorkerCompletedEventHandler;

            worker.SpaceChangedEvent += OnSpaceChangedEventHandler;

            worker.RunWorkerAsync(worker);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void worker_OnSpaceChanged(object sender, SpaceChangedEventArgs e)
        {
            ItemCounter++;                      

            float SpacePer = ((float)ItemCounter / (float)SpacesCount) * (float)100.00;

            toolStripLabel1.Text = "Processing (" + 
                ItemCounter.ToString() + " of " + SpacesCount.ToString() + ") (" +  
                SpacePer.ToString("##0.0") + "%): ";
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Invoice newInvoice = (Invoice)e.UserState;
            ListViewItem tmpItem = listView1.Items.Add(new ListViewItem(newInvoice.LegalEntity.Name, 0));
            tmpItem.SubItems.Add(newInvoice.LegalEntity.AccountNumber.ToString());
            tmpItem.SubItems.Add(newInvoice.LegalEntity.Phone);
            tmpItem.SubItems.Add(newInvoice.LegalEntity.Email);

            tmpItem.Checked = false;
          
            tmpItem.Tag = newInvoice;           
            
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnPost.Enabled = true;
            try
            {
                toolStripProgressBar1.Value = 1;
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;


                foreach (ListViewItem item in listView1.Items)
                {
                    Invoice invoice = (Invoice)item.Tag;
                    if (invoice.InvoiceDetails.Count > 0) item.Checked = true;
                    else item.Checked = false;

                }

                MessageBox.Show("Processing Complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateViewMenu(ToolStripSplitButton btnView)
        {
            foreach (View item in ValidViewValues)
            {
                ToolStripMenuItem tmp = new ToolStripMenuItem(item.ToString());
                tmp.Tag = item;
                tmp.DisplayStyle = ToolStripItemDisplayStyle.Text;
                btnView.DropDownItems.Add(tmp);
            }
        }

        private void btnView_ButtonClick(object sender, EventArgs e)
        {
            switch (listView1.View)
            {
                case View.Details:
                    listView1.View = View.LargeIcon;
                    break;
                case View.LargeIcon:
                    listView1.View = View.List;
                    break;
                case View.List:
                    listView1.View = View.SmallIcon;
                    break;
                case View.SmallIcon:
                    listView1.View = View.Details;
                    break;
            }
        }

        private void btnView_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in (sender as ToolStripSplitButton).DropDownItems)
            {
                item.Checked = (listView1.View == (View)item.Tag);
            }
        }

        private void btnView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            listView1.View = (View)e.ClickedItem.Tag;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.Checked)
                {
                    Invoice invoice = (Invoice)item.Tag;
                    invoice.LegalEntity = null;
                }
            }
            dc.SubmitChanges();
            this.Close();
        }

        private void frmPerformBilling_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (worker != null)
            {
                int changes = dc.GetChangeSet().Inserts.Count;
                if ((worker.IsBusy) || (changes > 0))
                    if (MessageBox.Show("Do you want to abandon this billing?", "End Processing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Remove event handlers so they aren't called after the form is gone
                        worker.ProgressChanged -= progressChangedEventHandler;
                        worker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
                        worker.CancelAsync();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Invoice invoice = (Invoice)listView1.SelectedItems[0].Tag;
                ShowInvoiceDetail(invoice);
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }
        }

        private void ShowInvoiceDetail(Invoice invoice)
        {
            tableLayoutPanel1.Visible = true;
            lblName.Text = invoice.LegalEntity.Name;
            lblTotal.Text = string.Format("{0:c}", invoice.TotalAmount);
            invoiceDetailBindingSource.DataSource = invoice.InvoiceDetails;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }

      
    }

    public delegate void SpaceChangedEventHandler(object sender, SpaceChangedEventArgs e);

    public class SpaceChangedEventArgs : EventArgs
    {
        public readonly object spaceObject;

        public SpaceChangedEventArgs(object SpaceObject)
        {
            spaceObject = SpaceObject;
        }
    }
       
    /// <summary>
    /// Invoice worker creates invoices for the business entites for each space
    /// in a background thread. It reports progress and completion.
    /// </summary>
    public class InvoiceWorker : BackgroundWorker
    {
        DBADataContext dc;
        IQueryable<Space> spaces;
        List<Invoice> invoices;
        int year;
        
        public event SpaceChangedEventHandler SpaceChangedEvent;

        public InvoiceWorker(DBADataContext dc, IQueryable<Space> spaces, List<Invoice> invoices, int year)
        {
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.dc = dc;
            this.spaces = spaces;
            this.invoices = invoices;
            this.year = year;
        }

        public void OnSpaceChanged(object SpaceObject)
        {
            if (SpaceChangedEvent != null) SpaceChangedEvent(this, new SpaceChangedEventArgs(SpaceObject));
        }

        /// <summary>
        /// The asynchronous worker method that performs the batch processing of invoices
        /// </summary>
        /// <param name="e">no parameter is expected</param>
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            var rates = dc.fn_GetRateMaster(new DateTime(year, 1, 1));
            int SpaceCounter = 0;

            foreach (Space space in spaces)
            {
                OnSpaceChanged(space);

                if (this.CancellationPending)
                    break;
                else
                {
                    var LEList = dc.fn_GetSpaceLegalEntitiesSummary_1(space.Id, year);
                    foreach (var item in LEList)
                        if (item.LegalEntityId.HasValue)
                        {
                            try
                            {
                                LegalEntity entity = dc.LegalEntities.First(delegate(LegalEntity le) { return le.Id == item.LegalEntityId; });
                                Invoice invoice = invoices.Find(delegate(Invoice i) { return i.LegalEntityId == item.LegalEntityId; });
                                if (invoice == null)
                                {
                                    invoice = new Invoice();
                                    invoice.BeginDate = new DateTime(year, 1, 1);
                                    invoice.EndDate = new DateTime(year, 12, 31);
                                    invoice.LegalEntity = entity;
                                    invoices.Add(invoice);
                                    this.ReportProgress(1, invoice);
                                }

                                // invoice now points to the invoice, go ahead and process the rules

                                bool RateApplied = false;
                                foreach (var rate in rates)
                                {
                                    string tmpDescr = string.Format("{0} {1} - {2} - {3} days", rate.RateCode, rate.Description, space.Address.AddressLine, item.Days);

                                    RateApplied = RateApplies(rate, space, entity, item.EntityType);
                                    if (RateApplied)
                                    {
                                        // compute the invoice line and
                                        InvoiceDetail detail = new InvoiceDetail();
                                        
                                        //string tmpDescr = string.Format("{0} {1} - {2} - {3} days", rate.RateCode, rate.Description, space.Address.AddressLine, item.Days);
                                        if (tmpDescr.Length >= 250)
                                            detail.Description = tmpDescr.Substring(0, 250);
                                        else
                                            detail.Description = tmpDescr;

                                        detail.Rate = rate.Rate;
                                        detail.RateCode = rate.RateCode;
                                        detail.RateFrequency = rate.RateFrequency;

                                        double tmpValue;
                                        if (double.TryParse(GetAttributeValue(space, rate.RateFrequency, entity, item.EntityType).ToString(), out tmpValue))
                                        {
                                            detail.Quantity = tmpValue;
                                            detail.Amount = Convert.ToDecimal(tmpValue * item.Portion.Value) * detail.Rate;
                                            // then add an entry to the invoice
                                            if (detail.Amount.Value > 0)
                                                invoice.InvoiceDetails.Add(detail);
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                // if we couldn't find the legal entity, then skip the legal entity Id
                                break;
                            }
                        }
                }

                int a = 0;
            }
        }


        private bool IsOwner(string entityType)
        {
            switch (entityType)
            {
                case "Owner":
                case "Vacant":
                    return true;
                case "Unbilled":
                case "Tenant":
                default:
                    return false;
            }
        }

        /// <summary>
        /// Locate the value for an attribute 
        /// </summary>
        /// <param name="space"></param>
        /// <param name="name"></param>
        /// <param name="entity"></param>
        /// <param name="isOwner"></param>
        /// <returns></returns>
        private object GetAttributeValue(Space space, string name, LegalEntity entity, string entityType)
        {
            if (name.Contains("DowntownBoiseAssociation.Space"))
            {
                return space.AttributeValue(name);
            }
            else if (name.Contains("DowntownBoiseAssociation.Tenant") && (!IsOwner(entityType)))
            {
                Tenant tmpT = space.SpaceTennants.First(delegate(SpaceTennant st) { return st.Tenant.LegalEntityId == entity.Id; }).Tenant;
                return tmpT.AttributeValue(name);
            }
            else if (name.Contains("DowntownBoiseAssociation.LegalEntity"))
            {
                return entity.AttributeValue(name);
            }
            else if (name.Contains("DowntownBoiseAssociation.Building"))
            {
                return space.Building.AttributeValue(name);
            }
            return null;
        }

        /// <summary>
        /// Evaluate the zone, rateFrequency (an attribute) as well as rules within the rate to see if the rule applies
        /// </summary>
        /// <param name="rate">The rate being evaluated</param>
        /// <param name="space">The space being checked against the rate</param>
        /// <param name="entity">The entity being billed for the rule</param>
        /// <param name="isOwner">Is the entity an owner (true) or the tennant (false)</param>
        /// <returns></returns>
        private bool RateApplies(RateMaster rate, Space space, LegalEntity entity, string entityType)
        {

            // the isOwner flag is only set to true when the property is vacant
            if (entityType != rate.EntityType) return false;

            // look for a match in the zone if the rate has a zone
            if (rate.ZoneId.HasValue)
            {
                // can't match if the building doesn't belong to a block
                if (!space.Building.BlockId.HasValue) return false;
                // no match if the zone Ids don't match
                if (rate.ZoneId.Value != space.Building.Block.ZoneId) return false;
            }

            object rateFrequency = GetAttributeValue(space, rate.RateFrequency, entity, rate.EntityType);
            if (rateFrequency == null) return false;

            foreach (var raterule in rate.RateRules)
            {
                object rateRuleValue = GetAttributeValue(space, raterule.Name, entity, entityType);
                switch (raterule.Comparison)
                {
                    case comparison.Exists:
                        if (rateRuleValue == null) return false; // if it contains any non-null value
                        break;
                    case comparison.DoesNotExist:
                        if (rateRuleValue != null) return false; // contains null
                        break;
                    case comparison.Equals: // Equals checks the string value only
                        if ((rateRuleValue == null) || (!rateRuleValue.ToString().Equals(raterule.Value))) return false;
                        break;
                    case comparison.GreaterThan:    // inequalities only work for numeric values
                    case comparison.LessThan:
                        double tmpRule;
                        double tmpValue;
                        if (!double.TryParse(raterule.Value.ToString(), out tmpRule)) return false;
                        if (!double.TryParse(rateRuleValue.ToString(), out tmpValue)) return false;
                        switch (raterule.Comparison)
                        {
                            case comparison.LessThan:
                                if (tmpRule <= tmpValue) return false;
                                break;
                            case comparison.GreaterThan:
                                if (tmpRule >= tmpValue) return false;
                                break;
                        }
                        break;
                    case comparison.DoesNotEqual: // Does Not Equal checks the string value only
                        if (rateRuleValue == null) return true;
                        if (rateRuleValue.ToString().Equals(raterule.Value)) return false;
                        break;
                    case comparison.DoesNotExistOrBlank:
                        if (rateRuleValue == null) return true;
                        if (rateRuleValue.ToString().Trim() != "") return false; // contains and empty string                        
                        break;
                }
            }
            return true;
        }
    }
}
