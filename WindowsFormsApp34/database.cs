using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp34
{
    public class Database
    {
        private static Database instance;
        private List<string> data; 

        private Database()
        {
            data = new List<string>();
        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public void AddData(string newData)
        {
            data.Add(newData);
        }

        public List<string> GetData()
        {
            return data;
        }
    }
}

