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

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.insert(0, "New Zealand");
            listBox1.Items.insert(1, "Australia");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selItem = listBox1.SelectedItem.ToString();

            if (selItem == "Australia")
            {
                String[] AUCity = { "Camberra", "Sydney", "Perth" };
                comboBox1.Items.AddRange(AUCity);
            }
            else
            {
                String[] NZCity = { "Wellington", "Hamilton", "Taupo" };
                comboBox1.Items.AddRange(NZCity);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show(name + " lives in " + listBox1.SelectedItem.ToString() + " , " + comboBox1.SelectedItem.ToString());
            name = "";
        }



    }
}
