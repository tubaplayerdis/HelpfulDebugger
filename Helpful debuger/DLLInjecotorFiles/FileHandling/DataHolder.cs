using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpful_debuger
{
    static class DataHolder
    {
        public static string savedDllPath = "";
        public static string savedProcess = "";
        public static bool closeOnInjection = false;
        public static bool injectOnStartup = false;
        public static int injectorMethod = 0;

        public static string getData()
        {
            string buf = "";
            buf += savedDllPath + "\n";
            buf += savedProcess + "\n";
            buf += closeOnInjection + "\n";
            buf += injectOnStartup + "\n";
            buf += injectorMethod + "\n";
            return buf;
        }

        public static int setData(string[] line)
        {
            if (line.Length == 5)
            {
                savedDllPath = line[0];
                savedProcess = line[1];
                closeOnInjection = (line[2] == "True") ? true : false;
                injectOnStartup = (line[3] == "True") ? true : false;
                injectorMethod = int.Parse(line[4]);
                return 1;
            }
            else if(line.Length == 0)
            {
                return 2;
            }

            return 0;
        }
    }
}
