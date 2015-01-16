using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DowntownBoiseAssociation.Classes
{
    class AddressHelper
    {
        private static DBADataContext dba = new DBADataContext();

        public static string FormatAddress(int inAddressId)
        {
            Address inAddress = (from a in dba.Addresses
                                 where a.Id == inAddressId
                                 select a).FirstOrDefault();

            if (inAddress == null) { return ""; }

            return
                ((((
                inAddress.StreetNumber.Trim() + " " +
                inAddress.StreetDirection.Trim()
                ).Trim() + " " +
                inAddress.StreetName.Trim()
                ).Trim() + " " +
                inAddress.StreetSuffix.Trim()
                ).Trim() + " " +
                inAddress.StreetSuite.Trim()
                ).Trim();
        }

        
        public static string FormatAddressExtended(int inAddressId)
        {
            Address inAddress = (from a in dba.Addresses
                                 where a.Id == inAddressId
                                 select a).FirstOrDefault();

            if (inAddress == null) { return ""; }

            return
                (((((((
                inAddress.StreetNumber.Trim() + " " +
                inAddress.StreetDirection.Trim()
                ).Trim() + " " +
                inAddress.StreetName.Trim()
                ).Trim() + " " +
                inAddress.StreetSuffix.Trim()
                ).Trim() + " " +
                inAddress.StreetSuite.Trim()
                ).Trim() + " " +
                inAddress.City.Trim()
                ).Trim() + " " +
                inAddress.State.Trim()
                ).Trim() + " " +
                inAddress.ZipCode.Trim()
                ).Trim();
        }

        public static int SpaceAddressId(int inSpaceId)
        {
            Space inSpace = (from a in dba.Spaces
                             where a.Id == inSpaceId
                             select a).FirstOrDefault();

            if (inSpace == null) { return 0; }

            return inSpace.AddressId;
        }
    }
}
