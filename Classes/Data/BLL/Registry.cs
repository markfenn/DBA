using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DowntownBoiseAssociation.BLL
{
    class Registry
    {
        private static string RegistryBase = "Software\\DowntownBoiseAssociation";
        
        public static void SaveProfile(string Key, string Value)
        {
            try
            {
                Microsoft.Win32.RegistryKey reg;
                reg = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(RegistryBase);

                reg.SetValue(Key, Value);
            }
            catch { }
        }

        public static string LoadProfile(string Key)
        {
            try
            {
                Microsoft.Win32.RegistryKey reg;
                reg = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(RegistryBase);

                return reg.GetValue(Key, "").ToString();              
            }
            catch { return "";  }
        }
    }
}
