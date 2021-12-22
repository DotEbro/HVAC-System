using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HVAC_Program
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Lahore")
            {
                OutTemp_box.Text = "41 °C";
                InTemp_box.Text = "35 °C";
                Conditioned_box.Text = "27 °C";
            }
            else if (comboBox1.Text == "Hyderabad")
            {
                OutTemp_box.Text = "38 °C";
                InTemp_box.Text = "33 °C";
                Conditioned_box.Text = "24 °C";
            }
            else if (comboBox1.Text == "Peshawar")
            {
                OutTemp_box.Text = "38 °C";
                InTemp_box.Text = "34 °C";
                Conditioned_box.Text = "26 °C";
            }
            else if (comboBox1.Text == "Islambad")
            {
                OutTemp_box.Text = "39 °C";
                InTemp_box.Text = "33 °C";
                Conditioned_box.Text = "27 °C";
            }
            else if (comboBox1.Text == "Khaniwal")
            {
                OutTemp_box.Text = "44 °C";
                InTemp_box.Text = "38 °C";
                Conditioned_box.Text = "28 °C";
            }
            else if (comboBox1.Text == "Jamshoro")
            {
                OutTemp_box.Text = "37 °C";
                InTemp_box.Text = "32 °C";
                Conditioned_box.Text = "24 °C";
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Please Fill the City Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                f2.Show();
            }
        }
    }
}
