using System;
using System.Windows.Forms;
using ParkingManager.GUI.Customer;
using ParkingManager.GUI.Setting;
using ParkingManager.GUI.Statistics;

namespace ParkingManager.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnParking_Click(null, null);
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            FrmParking frmParking = new FrmParking();
            frmParking.TopLevel = false;
            pnMain.Controls.Add(frmParking);
            frmParking.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmParking.Dock = DockStyle.Fill;
            frmParking.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = false;
            pnMain.Controls.Add(frmCustomer);
            frmCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCustomer.Dock = DockStyle.Fill;
            frmCustomer.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.TopLevel = false;
            pnMain.Controls.Add(frmStatistics);
            frmStatistics.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmStatistics.Dock = DockStyle.Fill;
            frmStatistics.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.TopLevel = false;
            pnMain.Controls.Add(frmSetting);
            frmSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSetting.Dock = DockStyle.Fill;
            frmSetting.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        
    }
}

