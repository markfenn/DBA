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
    public partial class dialogSearchSpace : Form
    {
        private DBADataContext dba = new DBADataContext();
        private int _SpaceId = 0;

        public dialogSearchSpace(string Title)
        {
            InitializeComponent();

            this.Text = Title;
        }

        public int SpaceId
        {
            get { return _SpaceId; }
        }
        
        private void FillTree()
        {
            Application.DoEvents();

            var BlockList = from a in dba.Blocks                            
                            orderby a.BlockNumber
                            select new
                                {
                                    a.Id,
                                    a.Name
                                };

            foreach (var BlockItem in BlockList)
            {   
                TreeNode BlockNode = new TreeNode();
                BlockNode.Text = BlockItem.Name;
                BlockNode.Tag = 0;

                var BuildingList = from a in dba.Buildings
                                   where a.BlockId == BlockItem.Id
                                   orderby a.Name
                                   select new
                                       {
                                           a.Id,
                                           a.Name
                                       };

                foreach (var BuildingItem in BuildingList)
                {
                    TreeNode BuildingNode = new TreeNode();
                    BuildingNode.Text = BuildingItem.Name;
                    BuildingNode.Tag = 0;

                    var SpaceList = from a in dba.vw_Spaces
                                    where a.BuildingId == BuildingItem.Id
                                    && a.TenantId == 0
                                    orderby a.SpaceName
                                    select a;

                    foreach (var SpaceItem in SpaceList)
                    {
                        TreeNode SpaceNode = new TreeNode();
                        SpaceNode.Text = SpaceItem.SpaceName;
                        SpaceNode.Tag = SpaceItem.SpaceId;

                        BuildingNode.Nodes.Add(SpaceNode);

                        Application.DoEvents();
                    }

                    if (BuildingNode.Nodes.Count != 0) { BlockNode.Nodes.Add(BuildingNode); }

                    Application.DoEvents();
                }

                if (BlockNode.Nodes.Count != 0) { treeViewSpaces.Nodes.Add(BlockNode); }

                Application.DoEvents();
            }   
        }

        private void dialogSearchSpace_Shown(object sender, EventArgs e)
        {
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
            FillTree();
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (treeViewSpaces.SelectedNode == null) { return; }

            _SpaceId = (int)treeViewSpaces.SelectedNode.Tag;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _SpaceId = 0;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
            

        private void treeViewSpaces_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ((int)e.Node.Tag == 0) { return; }

            _SpaceId = (int)e.Node.Tag;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
