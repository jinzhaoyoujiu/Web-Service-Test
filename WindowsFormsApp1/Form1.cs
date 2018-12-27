using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                var client = new ServiceReference1.WebService1SoapClient();
                textBox2.Text= client.RevertString(textBox1.Text);
            }
            else {
                MessageBox.Show("不能为空");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
