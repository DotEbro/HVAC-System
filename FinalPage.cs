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
    public partial class FinalPage : Form
    {
        Bed1 b1 = new Bed1();
        Bed2 b2 = new Bed2();
        Bath1 B1 = new Bath1();
        Bath2 B2 = new Bath2();
        Bath3 B3 = new Bath3();
        Lobby L = new Lobby();
        Kitchen K = new Kitchen();
        TV tv = new TV();
        Drawing D = new Drawing();
        FBed1 Fb1 = new FBed1();
        FBed2 Fb2 = new FBed2();
        FBed3 Fb3 = new FBed3();
        FBath1 FB1 = new FBath1();
        FBath2 FB2 = new FBath2();
        FBath3 FB3 = new FBath3();
        FLobby FL = new FLobby();
        FKitchen FK = new FKitchen();
        FTV Ftv = new FTV();
        double TotalLoad = 0;
        public FinalPage()
        {
            InitializeComponent();
        }

        private void FinalPage_Load(object sender, EventArgs e)
        {
            TotalLoad = b1.GetBed1() + b2.GetBed2() + B1.GetBath1() + B2.GetBath2() + B3.GetBath3() + L.GetLobby() + K.GetKitchen() + tv.GetTV() + D.GetDrawing() + Fb1.GetFBed1() + Fb2.GetFBed2() + Fb3.GetFBed3() + FB1.GetFBath1() + FB2.GetFBath2() + FB3.GetFBath3() + FL.GetFLobby() + FK.GetFKitchen() + Ftv.GetFTV();
            Total.Text = TotalLoad.ToString();
            
            if (b1.GetBed1() == 0)
            {
                BED1.Text = "0";
            }
            else
            {
                BED1.Text = b1.GetBed1().ToString();
            }
            ///////////////////////////////////////////
            if (b2.GetBed2() == 0)
            {
                BED2.Text = "0";
            }
            else
            {
                BED2.Text = b2.GetBed2().ToString();
            }
            ///////////////////////////////////////////
            if (B1.GetBath1() == 0)
            {
                BATH1.Text = "0";
            }
            else
            {
                BATH1.Text = B1.GetBath1().ToString();
            }
            ///////////////////////////////////////////
            if (B2.GetBath2() == 0)
            {
                BATH2.Text = "0";
            }
            else
            {
                BATH2.Text = B2.GetBath2().ToString();
            }
            ///////////////////////////////////////////
            if (B3.GetBath3() == 0)
            {
                BATH3.Text = "0";
            }
            else
            {
                BATH3.Text = B3.GetBath3().ToString();
            }
            ///////////////////////////////////////////
            if (L.GetLobby() == 0)
            {
                LOBBY.Text = "0";
            }
            else
            {
                LOBBY.Text = L.GetLobby().ToString();
            }
            ///////////////////////////////////////////
            if (K.GetKitchen() == 0)
            {
                KITCEN.Text = "0";
            }
            else
            {
                KITCEN.Text = K.GetKitchen().ToString();
            }
            ///////////////////////////////////////////
            if (tv.GetTV() == 0)
            {
                TV.Text = "0";
            }
            else
            {
                TV.Text = tv.GetTV().ToString();
            }
            ///////////////////////////////////////////
            if (D.GetDrawing() == 0)
            {
                DRAWING.Text = "0";
            }
            else
            {
                DRAWING.Text = D.GetDrawing().ToString();
            }
            ///////////////////////////////////////////
            ///////////////////////////////////////////
            if(Fb1.GetFBed1() == 0)
            {
                FBED1.Text = "0";
            }
            else
            {
                FBED1.Text = Fb1.GetFBed1().ToString();
            }
            ///////////////////////////////////////////
            if (Fb2.GetFBed2() == 0)
            {
                FBED2.Text = "0";
            }
            else
            {
                FBED2.Text = Fb2.GetFBed2().ToString();
            }
            ///////////////////////////////////////////
            if (FB1.GetFBath1() == 0)
            {
                FBATH1.Text = "0";
            }
            else
            {
                FBATH1.Text = FB1.GetFBath1().ToString();
            }
            ///////////////////////////////////////////
            if (FB2.GetFBath2() == 0)
            {
                FBATH2.Text = "0";
            }
            else
            {
                FBATH2.Text = FB2.GetFBath2().ToString();
            }
            ///////////////////////////////////////////
            if (FB3.GetFBath3() == 0)
            {
                FBATH3.Text = "0";
            }
            else
            {
                FBATH3.Text = FB3.GetFBath3().ToString();
            }
            ///////////////////////////////////////////
            if (FL.GetFLobby() == 0)
            {
                FLOBBY.Text = "0";
            }
            else
            {
                FLOBBY.Text = FL.GetFLobby().ToString();
            }
            ///////////////////////////////////////////
            if (FK.GetFKitchen() == 0)
            {
                FKITCHEN.Text = "0";
            }
            else
            {
                FKITCHEN.Text = FK.GetFKitchen().ToString();
            }
            ///////////////////////////////////////////
            if (Ftv.GetFTV() == 0)
            {
                FTV.Text = "0";
            }
            else
            {
                FTV.Text = Ftv.GetFTV().ToString();
            }
            ///////////////////////////////////////////
            if (Fb3.GetFBed3() == 0)
            {
                FBED3.Text = "0";
            }
            else
            {
                FBED3.Text = Fb3.GetFBed3().ToString();
            }
            ///////////////////////////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        
        public void showValue(int INC)
        {
            TotalLoad = INC;

        }
    }
}
