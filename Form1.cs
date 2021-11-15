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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           String[] City = { "Wellington", "Hamilton", "Taupo" };
            comboBox1.Items.AddRange(City);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] Country = { "New Zealand", "Australia" };
            comboBox3.Items.AddRange(Country);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Input combo1 lives in " + comboBox2.SelectedItem.ToString() + " , " + comboBox3.SelectedItem.ToString());
        }



    }
}
