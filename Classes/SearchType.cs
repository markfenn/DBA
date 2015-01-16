using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DowntownBoiseAssociation.Classes
{
    public class SearchList
    {
        private int _Id;
        private string _SearchText;
        private string _IdString;

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string SearchText
        {
            set { _SearchText = value; }
            get { return _SearchText; }
        }
        public string IdString
        {
            set { _IdString = value; }
            get { return _IdString; }
        }
    }
}
