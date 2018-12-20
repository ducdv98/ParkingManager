using System;
using System.Drawing;
using System.Windows.Forms;
using ParkingManager.GUI.Parking;

namespace ParkingManager.GUI
{
    public partial class FrmParking : Form
    {
        public FrmParking()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnIn_Click(null, null);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            PnlGetIn pnlIn = new PnlGetIn();
            pnlIn.TopLevel = false;
            pnMain.Controls.Add(pnlIn);
            pnlIn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlIn.Dock = DockStyle.Fill;
            pnlIn.Show();
            btnIn.BackColor = Color.DodgerBlue;
            btnOut.BackColor = Color.White;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            PnlGetOut pnlOut = new PnlGetOut();
            pnlOut.TopLevel = false;
            pnMain.Controls.Add(pnlOut);
            pnlOut.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlOut.Dock = DockStyle.Fill;
            pnlOut.Show();
            btnOut.BackColor = Color.DodgerBlue;
            btnIn.BackColor = Color.White;

        }
    }
}
