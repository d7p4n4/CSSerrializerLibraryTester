using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSerializerLibrary;

namespace CSSerrializerLibraryTester
{
    //2019. 10. 24. 14:04
    class Program
    {
        private static readonly string PATH = ConfigurationManager.AppSettings["path"];
        static void Main(string[] args)
        {

            System.Reflection.Assembly a = System.Reflection.Assembly.Load("CSSerrializerLibraryTester");
            var allTypes = a.GetTypes();

            foreach(var type in allTypes)
            {
                Generate.SerializeClasses(type, PATH);
            }
        }
    }
}
