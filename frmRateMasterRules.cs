using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace DowntownBoiseAssociation
{
    public partial class frmRateMasterRules : Form
    {
        private RateMaster _rateMaster;

        public frmRateMasterRules(RateMaster rateMaster)
        {
            _rateMaster = rateMaster;
            this.Load += new EventHandler(frmRateMasterRules_Load);
            InitializeComponent();
        }

        void frmRateMasterRules_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView.
            dgRules.AutoGenerateColumns = false;
            dgRules.AutoSize = true;
            dgRules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgRules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Initialize and add a text box column.
            DBADataContext dc = new DBADataContext();
            DataGridViewComboBoxColumn dgcName = new DataGridViewComboBoxColumn();
            dgcName.ValueType = typeof(string);
            dgcName.DataSource = dc.AttributeNames();
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "Name";

            DataGridViewComboBoxColumn dgcComparison = new DataGridViewComboBoxColumn();
            dgcComparison.ValueType = typeof(DowntownBoiseAssociation.comparison);
            dgcComparison.DataSource = Enum.GetValues(typeof(DowntownBoiseAssociation.comparison));
            dgcComparison.DataPropertyName = "Comparison";
            dgcComparison.HeaderText = "Comparison";

            // Initialize and add a check box column.
            DataGridViewColumn dgcValue = new DataGridViewTextBoxColumn();
            dgcValue.DataPropertyName = "Value";
            dgcValue.HeaderText = "Value";

            dgRules.Columns.Add(dgcName);
            dgRules.Columns.Add(dgcComparison);
            dgRules.Columns.Add(dgcValue);

            dgRules.DataSource = _rateMaster.RateRules;
        }

        private void dgRules_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
