using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVAC_Program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if(GroundFloorbtn.Checked == true && FirstFloorbtn.Checked == false)
            {
                if(Bed1btn.Checked == true)
                {
                    this.Hide();
                    Bed1 bed1 = new Bed1();
                    bed1.Show();
                }
                else if (Bed2btn.Checked == true)
                {
                    this.Hide();
                    Bed2 bed2 = new Bed2();
                    bed2.Show();
                }
                else if (Bath1btn.Checked == true)
                {
                    this.Hide();
                    Bath1 bath1 = new Bath1();
                    bath1.Show();
                }
                else if (Bath2btn.Checked == true)
                {
                    this.Hide();
                    Bath2 bath2 = new Bath2();
                    bath2.Show();
                }
                else if (Bath3btn.Checked == true)
                {
                    this.Hide();
                    Bath3 bath3 = new Bath3();
                    bath3.Show();
                }
                else if (Drawingbtn.Checked == true)
                {
                    this.Hide();
                    Drawing drawing = new Drawing();
                    drawing.Show();
                }
                else if (Lobbybtn.Checked == true)
                {
                    this.Hide();
                    Lobby lobby = new Lobby();
                    lobby.Show();
                }
                else if (Kitchenbtn.Checked == true)
                {
                    this.Hide();
                    Kitchen kitchen = new Kitchen();
                    kitchen.Show();
                }
                else if (TVbtn.Checked == true)
                {
                    this.Hide();
                    TV tv = new TV();
                    tv.Show();
                }
                else
                {
                    MessageBox.Show("Please select one option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (GroundFloorbtn.Checked == false && FirstFloorbtn.Checked == true)
            {
                if (FBed1btn.Checked == true)
                {
                    this.Hide();
                    FBed1 fbed1 = new FBed1();
                    fbed1.Show();
                }
                else if (FBed2btn.Checked == true)
                {
                    this.Hide();
                    FBed2 fbed2 = new FBed2();
                    fbed2.Show();
                }
                else if (FBath1btn.Checked == true)
                {
                    this.Hide();
                    FBath1 fbath1 = new FBath1();
                    fbath1.Show();
                }
                else if (FBath2btn.Checked == true)
                {
                    this.Hide();
                    FBath2 fbath2 = new FBath2();
                    fbath2.Show();
                }
                else if (FBath3btn.Checked == true)
                {
                    this.Hide();
                    FBath3 fbath3 = new FBath3();
                    fbath3.Show();
                }
                else if (FBed3btn.Checked == true)
                {
                    this.Hide();
                    FBed3 fbed3 = new FBed3();
                    fbed3.Show();
                }
                else if (FLobby.Checked == true)
                {
                    this.Hide();
                    FLobby flobby= new FLobby();
                    flobby.Show();
                }
                else if (FKitchen.Checked == true)
                {
                    this.Hide();
                    FKitchen fkitchen = new FKitchen();
                    fkitchen.Show();
                }
                else if (FTV.Checked == true)
                {
                    this.Hide();
                    FTV ftv = new FTV();
                    ftv.Show();
                }
                else
                {
                    MessageBox.Show("Please select one option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select one option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
