using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp34
{
    public class logger
    {
        private static logger Instance;
        List <string>loglist = new List<string>();
        private logger()
        { 
      
        }
        public static logger GetInstance()
        {
            if (Instance == null)
            {
                Instance = new logger();
            }
            return Instance;

        }
        public void addToLog(string cmd)
        {
        loglist.Add(cmd);
        }
        public string[] Tostring()
        {
            return loglist.ToArray();
        }
    }

}
