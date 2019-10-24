using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSerializerLibrary;

namespace CSSerrializerLibraryTester
{
    //2019. 10. 24. 12:06
    class Program
    {
        public const string PATH = CSSerializerLibrary.Program.PATH;
        static void Main(string[] args)
        {
            Generate.SerializeClasses(typeof(Student), PATH);
        }
    }
}
