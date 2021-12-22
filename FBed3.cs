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

    public partial class FBed3 : Form
    {
        public static double HeatOFEastWindow = 0;
        public static double HeatOFWestWindow = 0;
        public static double HeatOFNorthP_Wall = 0;
        public static double HeatOFWestP_Wall = 0;
        public static double HeatOFSouthP_Wall = 0;
        public static double HeatOFEastEX_Wall = 0;
        public static double HeatOFRoof = 0;
        public static double HeatOFEastDoor = 0;
        public static double HeatOFWestDoor = 0;
        public static double HeatOfInfl = 0;
        public static double HeatofLamps = 0;
        public static double HeatofPeople = 0;
        public static double HeatofAC = 0;
        public static double HeatofFans = 0;
        public static double TotalRoomHeat = 0;

        public FBed3()
        {
            InitializeComponent();
        }
        private void WinHbtn_Click(object sender, EventArgs e)
        {
            if (Window.Text == "North")
            {
                HeatOFEastWindow = (double.Parse(WinLen.Text) * double.Parse(WinWid.Text) * 139) / 1000;
                WinH_N.Text = HeatOFEastWindow.ToString();
            }
            if (Window.Text == "West")
            {
                HeatOFWestWindow = (double.Parse(WinLen.Text) * double.Parse(WinWid.Text) * 511) / 1000;
                WinH_N.Text = HeatOFWestWindow.ToString();
            }
            else
            {
                MessageBox.Show("Please select any Orientation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PWallHbtn_Click(object sender, EventArgs e)
        {
            if (PartitionWall.Text == "East")
            {
                HeatOFNorthP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 14) / 1000;
                PWallH_N.Text = HeatOFNorthP_Wall.ToString();
            }
            else if (PartitionWall.Text == "West")
            {
                HeatOFWestP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 14) / 1000;
                PWallH_W.Text = HeatOFWestP_Wall.ToString();
            }
            else if (PartitionWall.Text == "North")
            {
                HeatOFSouthP_Wall = (0.4789 * double.Parse(PWallLen.Text) * double.Parse(PWallHeight.Text) * 14) / 1000;
                PWallH_S.Text = HeatOFSouthP_Wall.ToString();
            }
            else
            {
                MessageBox.Show("Please select any Orientation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EWallHbtn_Click(object sender, EventArgs e)
        {
            if (ExposedWall.Text == "South")
            {
                HeatOFEastEX_Wall = (0.4789 * double.Parse(EWallLen.Text) * double.Parse(EWallHeight.Text) * 18) / 1000;
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
            if (Door.Text == "East")
            {
                HeatOFEastDoor = (0.18 * double.Parse(DoorLen.Text) * double.Parse(DoorWidth.Text) * 8) / 1000;
                DoorHeat_E.Text = HeatOFEastDoor.ToString();
            }
            else if (Door.Text == "West")
            {
                HeatOFWestDoor = (0.18 * double.Parse(DoorLen.Text) * double.Parse(DoorWidth.Text) * 8) / 1000;
                DoorHeat_W.Text = HeatOFWestDoor.ToString();
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
            if (LampsNOs.Text != "")
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
                HeatofPeople = (70 * 0.80 * double.Parse(PeopleNO.Text)) / 1000;
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
            TotalRoomHeat = HeatOFEastWindow + HeatOFWestWindow + HeatOFNorthP_Wall + HeatOFWestP_Wall + HeatOFSouthP_Wall + HeatOFEastEX_Wall + HeatOFRoof + HeatOFEastDoor + HeatOFWestDoor + HeatOfInfl + HeatofLamps + HeatofPeople + HeatofAC + HeatofFans;
            LoadBox.Text = TotalRoomHeat.ToString();
        }
        public double GetFBed3()
        {
            return TotalRoomHeat;
        }
        private void NextRoom_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalPage fg = new FinalPage();
            fg.Show();
        }
    }
}
