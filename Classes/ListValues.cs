using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DowntownBoiseAssociation.Classes
{
    public class ListValues
    {
        public static List<cbItem> StreetDirections()
        {
            List<cbItem> NewList = new List<cbItem>();

            NewList.Add(new cbItem(" ", " "));
            NewList.Add(new cbItem("N","N"));
            NewList.Add(new cbItem("E","E"));
            NewList.Add(new cbItem("S","S"));
            NewList.Add(new cbItem("W","W"));
            NewList.Add(new cbItem("NE","NE"));
            NewList.Add(new cbItem("NW","NW"));
            NewList.Add(new cbItem("SE","SE"));
            NewList.Add(new cbItem("SW","SW"));

            return NewList;
        }

        public static List<cbItem> StreetSuffixes()
        {
            List<cbItem> NewList = new List<cbItem>();

            NewList.Add(new cbItem(" ", " "));
            NewList.Add(new cbItem("AVE", "AVE"));
            NewList.Add(new cbItem("BLVD", "BLVD"));
            NewList.Add(new cbItem("CIR", "CIR"));
            NewList.Add(new cbItem("CT", "CT"));
            NewList.Add(new cbItem("DR", "DR"));
            NewList.Add(new cbItem("HWY", "HWY"));
            NewList.Add(new cbItem("LN", "LN"));
            NewList.Add(new cbItem("PL", "PL"));
            NewList.Add(new cbItem("PKWY", "PKWY"));
            NewList.Add(new cbItem("RD", "RD"));
            NewList.Add(new cbItem("ST", "ST"));
            NewList.Add(new cbItem("WAY", "WAY"));

            return NewList;
        }

    }
    public class cbItem
    {
        private string _Text;
        private string _Value;

        public cbItem(string Text, string Value)
        {
            _Text = Text;
            _Value = Value;
        }

        public string Text
        { get { return _Text; } }

        public string Value
        { get { return _Value; } }
    }
}
