using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSerializerLibrary;

namespace CSSerrializerLibraryTester
{
    //2019. 10. 24. 14:39
    class Program
    {
        private static readonly string PATH = ConfigurationManager.AppSettings["path"];
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string APPSETTINGS_CLASSNAME = ConfigurationManager.AppSettings["className"];

        private static string GetAppConfigStringParameter(string name)
        {

            return ConfigurationManager.AppSettings.Get(name);

        }

        static void Main(string[] args)
        {

            log.Debug("path:" + GetAppConfigStringParameter(APPSETTINGS_CLASSNAME));

            try
            {

                System.Reflection.Assembly a = System.Reflection.Assembly.Load("CSSerrializerLibraryTester");
                var allTypes = a.GetTypes();

                foreach (var type in allTypes)
                {
                    Generate.SerializeClasses(type, PATH);
                }
            } catch (Exception _exception)
            {
                log.Error(_exception.Message);
            }
        }
    }
}
