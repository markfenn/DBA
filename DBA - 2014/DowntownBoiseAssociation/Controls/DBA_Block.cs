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
    public partial class DBA_Block : UserControl
    {
        private DBADataContext dba = new DBADataContext();
        private List<StreetType> _Streets = new List<StreetType>();
        private Block _Block;
        private int _TenantId;

        public DBA_Block()
        {
            InitializeComponent();
        }
        
        public int TenantId 
        { 
            set 
            { 
                _TenantId = value;
                FillControl();
            }
            get { return _TenantId; }
        }

        private void FillControl()
        {
            _Block = (from c in dba.Blocks
                      join d in dba.Buildings
                      on c.Id equals d.BlockId
                      join e in dba.Spaces
                      on d.Id equals e.BuildingId
                      join f in dba.SpaceTennants
                      on e.Id equals f.SpaceId
                      join g in dba.Tenants
                      on f.TenantId equals g.Id
                      where f.TenantId == _TenantId
                      select c).FirstOrDefault();

            var _lStreets = from a in dba.Streets
                            join b in dba.StreetBlocks
                            on a.Id equals b.StreetId
                            join c in dba.Blocks
                            on b.BlockId equals c.Id
                            join d in dba.Buildings
                            on c.Id equals d.BlockId
                            join e in dba.Spaces
                            on d.Id equals e.BuildingId
                            join f in dba.SpaceTennants
                            on e.Id equals f.SpaceId
                            join g in dba.Tenants
                            on f.TenantId equals g.Id
                            where f.TenantId == _TenantId
                            select new
                            {
                                StreetName = a.Name,
                                StreetDirection = b.Direction
                            };
            foreach (var item in _lStreets)
            {
                StreetType NewStreet = new StreetType(item.StreetName, item.StreetDirection);
                _Streets.Add(NewStreet);
            }

            foreach (StreetType item in _Streets)
            {
                if (item.StreetDirection == "N") { lblStreetNorth.Text = item.StreetName; }
                if (item.StreetDirection == "E") { lblStreetEast.Text = item.StreetName; }
                if (item.StreetDirection == "S") { lblStreetSouth.Text = item.StreetName; }
                if (item.StreetDirection == "W") { lblStreetWest.Text = item.StreetName; }
            }

            if (_Block != null) { lblBlockName.Text = _Block.BlockNumber + "\r\n(" + _Block.Name.Trim() + ")"; }
            else { lblBlockName.Text = "No Block Data"; }
        }

        
    }

    class StreetType
    {
        public string StreetName;
        public string StreetDirection;

        public StreetType(string sName, string sDirection)
        {
            StreetName = sName;
            StreetDirection = sDirection;
        }
    }
}
