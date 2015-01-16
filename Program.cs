using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;

namespace DowntownBoiseAssociation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.GetDomain().AssemblyResolve += new ResolveEventHandler(Program_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }

        public static Assembly DynamicAssembly
        {
            get
            {
                return Program_AssemblyResolve(null, null);
            }
        }

        /// <summary>
        /// A singleton for the dynamic assembly, so we only create it once
        /// </summary>
        private static Assembly DBAEnumAssembly;

        /// <summary>
        /// If an unknown type is created using Activator.CreateInstance("DowntownBoiseAssociation.ClassCategories", "ANonExistentType");
        /// then this method is called and a dynamic assembly is invoked containing the needed types. This dynamic assembly
        /// is only created in memory (not saved) and reflects the database state when the application started.
        /// </summary>
        /// <returns>A dynamic assembly containing enumerations for the Class database values</returns>
        static System.Reflection.Assembly Program_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (DBAEnumAssembly == null)
            {
                AssemblyName aname = new AssemblyName("DowntownBoiseAssociation.ClassCategories");
                AssemblyBuilder abuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(aname, AssemblyBuilderAccess.Run);
                ModuleBuilder mbuilder = abuilder.DefineDynamicModule(abuilder + ".dll");

                DBADataContext dc = new DBADataContext();

                var enumNames = (from c in dc.Classes
                                 select c.ClassType).Distinct();

                foreach (string enumName in enumNames)
                {
                    EnumBuilder eBuilder = mbuilder.DefineEnum(
                        "DowntownBoiseAssociation.ClassCategories" + "." + enumName, 
                        TypeAttributes.Public, typeof(int));

                    var enumValues = (from c in dc.Classes
                                      where c.ClassType.Equals(enumName)
                                      select c.Name).Distinct();

                    int idx = 0;
                    foreach (string enumValue in enumValues)
                    {
                        eBuilder.DefineLiteral(enumValue, idx++);
                    }
                    eBuilder.CreateType();
                }
                DBAEnumAssembly = abuilder;
            }
            return DBAEnumAssembly;
        }
    }
}
