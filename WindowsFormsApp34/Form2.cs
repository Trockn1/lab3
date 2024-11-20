using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        logger log = logger.GetInstance();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1.Text);
            double d2 = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(d1 + d2);
            log.addToLog(DateTime.Today.ToString()+":"+ textBox1.Text+"+"+ textBox2.Text+"="+ label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1.Text);
            double d2 = Convert.ToDouble(textBox2.Text);
            label1.Text = (d1 + d2).ToString();
            log.addToLog(DateTime.Today.ToString() + ":" + textBox1.Text + "-" + textBox2.Text + "=" + label1.Text);
        }
    }
}
