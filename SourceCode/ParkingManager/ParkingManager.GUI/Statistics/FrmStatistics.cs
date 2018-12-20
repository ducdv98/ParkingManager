using ParkingManager.Data.DTO;
using ParkingManager.Data.Repositories;
using System;
using System.Windows.Forms;

namespace ParkingManager.GUI.Statistics
{
    public partial class FrmStatistics : Form
    {
        private StatistiscDao statistiscDao;
        private ParkingDao parkingDao;

        public FrmStatistics()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            statistiscDao = new StatistiscDao();
            parkingDao = new ParkingDao();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            RevenueDto revenue = statistiscDao.GetRevenue(DateTime.Now);
            if (revenue != null)
            {
                tbRevenueOfTerm.Text = revenue.RevenueFromTermMode.ToString("###,###");
                tbRevenueOfTurn.Text = revenue.RevenueFromTurnMode.ToString("###,###");
                tbTotalRevenue.Text = revenue.TotalRevenue.ToString("###,###");
            }
            else
            {
                MessageBox.Show("Chưa có doanh thu cho tháng này!", "Lỗi", MessageBoxButtons.OK);
            }

            int[] value = statistiscDao.GetNumberOfTicket();
            if (value != null && value.Length > 0)
            {
                lbNumberOfTicket.Text = value[0].ToString();
                lbNumberOfUsedTicket.Text = value[1].ToString();
            }
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            RevenueDto revenue = statistiscDao.GetRevenue(timePicker.Value);
            if (revenue != null)
            {
                tbRevenueOfTerm.Text = revenue.RevenueFromTermMode.ToString("###,###");
                tbRevenueOfTurn.Text = revenue.RevenueFromTurnMode.ToString("###,###");
                tbTotalRevenue.Text = revenue.TotalRevenue.ToString("###,###");
            }
            else
            {
                MessageBox.Show("Chưa có doanh thu cho tháng này!", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedIndex != -1)
            {
                AreaDto thisArea;
                thisArea = parkingDao.GetInformationAboutArea(cbArea.SelectedIndex + 1);
                if (thisArea == null)
                {
                    return;
                }
                lbTotal.Text = thisArea.MaxVolume.ToString();
                lbAvailable.Text = thisArea.Available.ToString();
            }
        }
    }
}
