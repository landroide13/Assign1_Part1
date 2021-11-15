using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           String[] Country = { "New Zealand", "Australia" };
           comboBox2.Items.AddRange(Country);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String[] City = { "Wellington", "Hamilton", "Taupo" };
            comboBox1.Items.AddRange(City);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "lives in " + listBox1.SelectedItem.ToString() + " , " + comboBox1.SelectedItem.ToString());
        }



    }
}
