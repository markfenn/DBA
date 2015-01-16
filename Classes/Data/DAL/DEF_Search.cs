using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DowntownBoiseAssociation.DAL.RecordDef
{
    public class Search
    {
        private string _Name;
        private int _Id;
        private DowntownBoiseAssociation.Controls.SearchItemType _Type;

        public Search() { }

        public Search(string Name,
            int Id,
            DowntownBoiseAssociation.Controls.SearchItemType Type)
        {
            _Name = Name;
            _Type = Type;
            _Id = Id;
        }


    }
}
