using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public class DataSaver
    {
        private static DataSaver _instance;
        private static readonly object _lock = new object();

        private DataSaver() { }

        public static DataSaver Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataSaver();
                    }
                }
                return _instance;
            }
        }

        public void SaveData(DataGridView dataGridView, string name, decimal amount)
        {
            int rowIndex = dataGridView.Rows.Add();
            DataGridViewRow newRow = dataGridView.Rows[rowIndex];

            newRow.Cells["Name"].Value = name; 
            newRow.Cells["Amount"].Value = amount; 
        }
    }


}
