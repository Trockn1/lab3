using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePerformanceCounter();
        }
        logger log = logger.GetInstance();
        private void InitializePerformanceCounter()
        {
            try
            {
                performanceCounter1.CategoryName = "Processor";
                performanceCounter1.CounterName = "% Processor Time";
                performanceCounter1.InstanceName = "_Total";

                float initialValue = performanceCounter1.NextValue();
                MessageBox.Show($"Ініціалізація завершена. Початкове значення: {initialValue}%", "Інформація");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації PerformanceCounter: {ex.Message}", "Помилка");
            }
           
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            log.addToLog(DateTime.Today.ToString() + ":" + "add student" + textBox1.Text + "to list");


            try
            {
                float cpuUsage = performanceCounter1.NextValue();
                MessageBox.Show($"Завантаження процесора: {cpuUsage}%", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка");
            }
        }



        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(log.Tostring());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                decimal amount = decimal.Parse(textBox1.Text);

                DataSaver.Instance.SaveData(dataGridView1, name, amount);

                MessageBox.Show("Data saved to DataGridView successfully!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database db = Database.GetInstance();

            string text = textBox2.Text;
            db.AddData(text);

            dataGridView1.Rows.Clear();

            List<string> allData = db.GetData();

            foreach (string item in allData)
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
    

