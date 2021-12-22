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
    public partial class FBed1 : Form
    {
        public static double HeatOFNorthWindow = 0;
        public static double HeatOFWestWindow = 0;
        public static double HeatOFNorthP_Wall = 0;
        public static double HeatOFWestP_Wall = 0;
        public static double HeatOFSouthP_Wall = 0;
        public static double HeatOFEastEX_Wall = 0;
        public static double HeatofOven = 0;
        public static double HeatofToaster = 0;
        public static double HeatOFRoof = 0;
        public static double HeatOFDoor = 0;
        public static double HeatOfInfl = 0;
        public static double HeatofLamps = 0;
        public static double HeatofPeople = 0;
        public static double HeatofAC = 0;
        public static double HeatofFans = 0;
        public static double TotalRoomHeat = 0;

        public FBed1()
        {
            InitializeComponent();
        }

        private void WinHbtn_Click(object sender, EventArgs e)
        {
            if(Window.Text == "North")
            {
                HeatOFNorthWindow = (double.Parse(WinLen.Text) * double.Parse(WinWid.Text) * 139) / 1000;
                WinH_N.Text = HeatOFNorthWindow.ToString();
            }
            else if (Window.Text == "West")
            {
                HeatOFWestWindow = (double.Parse(WinLen.Text) * double.Parse(WinWid.Text) * 511) / 1000;
                WinH_W.Text = HeatOFWestWindow.ToString();
            }
            else
            {
                MessageBox.Show("Please select any Orientation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PWallHbtn_Click(object sender, EventArgs e)
        {
            if(PartitionWall.Text == "North")
            {
                HeatOFNorthP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 8) / 1000;
                PWallH_N.Text = HeatOFNorthP_Wall.ToString();
            }
            else if (PartitionWall.Text == "West")
            {
                HeatOFWestP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 8) / 1000;
                PWallH_W.Text = HeatOFWestP_Wall.ToString();
            }
            else if (PartitionWall.Text == "South")
            {
                HeatOFSouthP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 8) / 1000;
                PWallH_S.Text = HeatOFSouthP_Wall.ToString();
            }
            else
            {
                MessageBox.Show("Please select any Orientation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EWallHbtn_Click(object sender, EventArgs e)
        {
            if(ExposedWall.Text == "East")
            {
                HeatOFEastEX_Wall = (0.4789 * double.Parse(EWallLen.Text) * double.Parse(EWallHeight.Text) * 22) / 1000;
                EWallH_E.Text = HeatOFEastEX_Wall.ToString();
            }
            else
            {
                MessageBox.Show("Please select any Orientation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RoofHeatbtn_Click(object sender, EventArgs e)
        {
            if (RoofLen.Text != "" && RoofWid.Text != "")
            {
                HeatOFRoof = (0.28 * double.Parse(RoofLen.Text) * double.Parse(RoofWid.Text) * 14) / 1000;
                RoofHeat.Text = HeatOFRoof.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the length and Width field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DoorHeatbtn_Click(object sender, EventArgs e)
        {
            if (DoorLen.Text != "" && DoorWidth.Text != "")
            {
                HeatOFDoor = (0.18 * double.Parse(DoorLen.Text) * double.Parse(DoorWidth.Text) * 14) / 1000;
                DoorHeat.Text = HeatOFDoor.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the length and Width field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Infl_Heatbtn_Click(object sender, EventArgs e)
        {
            if (Infl_Height.Text != "" && Infl_Width.Text != "" && Infil_Len.Text != "")
            {
                HeatOfInfl = (1.2 * (0.5 * double.Parse(Infil_Len.Text) * double.Parse(Infl_Width.Text) * double.Parse(Infl_Height.Text) * 1000 / 3600) * 8) / 1000;
                Infl_Heat.Text = HeatOfInfl.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the length and Width field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lampsbtn_Click(object sender, EventArgs e)
        {
            if(LampsNOs.Text != "")
            {
                HeatofLamps = (25 * 1.2 * 0.95 * double.Parse(LampsNOs.Text)) / 1000;
                LampsHeat.Text = HeatofLamps.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the Lamps field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Peoplebtn_Click(object sender, EventArgs e)
        {
            if (PeopleNO.Text != "")
            {
                HeatofPeople = (70 * 0.80 * double.Parse(PeopleNO.Text)) /1000;
                PeopleHeat.Text = HeatofPeople.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the Lamps field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void ACbtn_Click(object sender, EventArgs e)
        {
            if (NoOfAC.Text != "")
            {
                HeatofAC = (1500 * double.Parse(NoOfAC.Text)) / 100;
                ACheat.Text = HeatofAC.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the Lamps field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Fansbtn_Click(object sender, EventArgs e)
        {
            if (NoOfFans.Text != "")
            {
                HeatofFans = (50 * double.Parse(NoOfFans.Text)) / 1000;
                FansHeat.Text = HeatofFans.ToString();
            }
            else
            {
                MessageBox.Show("Please fill the Lamps field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcLoadbtn_Click(object sender, EventArgs e)
        {
            TotalRoomHeat = HeatOFNorthWindow + HeatOFWestWindow + HeatOFNorthP_Wall + HeatOFWestP_Wall + HeatOFSouthP_Wall + HeatOFEastEX_Wall + HeatOFRoof + HeatOFDoor + HeatOfInfl + HeatofLamps + HeatofPeople + HeatofAC + HeatofFans;
            LoadBox.Text = TotalRoomHeat.ToString();
        }
        public double GetFBed1()
        {
            return TotalRoomHeat;
        }
        private void NextRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalPage fg = new FinalPage();
            fg.Show();
        }
    }
}
