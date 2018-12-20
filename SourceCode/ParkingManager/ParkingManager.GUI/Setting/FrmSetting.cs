using ParkingManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ParkingManager.Data.Common;

namespace ParkingManager.GUI.Setting
{
    public partial class FrmSetting : Form
    {
        private SettingDao settingDao;

        public FrmSetting()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            settingDao = new SettingDao();
        }

        private void btnAllowEdit_Click(object sender, EventArgs e)
        {
            tbBike.Enabled = true;
            tbBikeT.Enabled = true;
            tbEbike.Enabled = true;
            tbEbikeT.Enabled = true;
            tbMotorBike.Enabled = true;
            tbMotorBikeT.Enabled = true;
            tbTriCycle.Enabled = true;
            tbTriCycleT.Enabled = true;
            btnSave.Enabled = true;
        }

        private void tbBike_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            List<decimal> newPriceList = new List<decimal>(8);
            newPriceList.Add(Decimal.Parse(tbBike.Text));
            newPriceList.Add(Decimal.Parse(tbBikeT.Text));
            newPriceList.Add(Decimal.Parse(tbEbike.Text));
            newPriceList.Add(Decimal.Parse(tbEbikeT.Text));
            newPriceList.Add(Decimal.Parse(tbMotorBike.Text));
            newPriceList.Add(Decimal.Parse(tbMotorBikeT.Text));
            newPriceList.Add(Decimal.Parse(tbTriCycle.Text));
            newPriceList.Add(Decimal.Parse(tbTriCycleT.Text));
            
            int result = settingDao.UpdatePriceList(newPriceList);
            if (result == Constants.RESULT_OK)
            {
                RefreshUI();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshUI()
        {
            foreach (Control c in gbTurn.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox groupBox = c as GroupBox;
                    c.Enabled = false;
                }
            }
            foreach (Control c in gbTerm.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox groupBox = c as GroupBox;
                    c.Enabled = false;
                }
            }

            btnSave.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (tbBike.Text.Equals("") || tbBikeT.Text.Equals("") || tbEbike.Text.Equals("") ||
                tbEbikeT.Text.Equals("") || tbMotorBike.Text.Equals("") || tbMotorBikeT.Text.Equals("") ||
                tbTriCycle.Text.Equals("") || tbTriCycleT.Text.Equals(""))
                return false;
            return true;
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            List<decimal> priceList =  settingDao.GetPriceList();
            if (priceList != null && priceList.Count == 8)
            {
                tbBike.Text = priceList[0].ToString("##,###");
                tbBikeT.Text = priceList[1].ToString("##,###");
                tbEbike.Text = priceList[2].ToString("##,###");
                tbEbikeT.Text = priceList[3].ToString("##,###");
                tbMotorBike.Text = priceList[4].ToString("##,###");
                tbMotorBikeT.Text = priceList[5].ToString("##,###");
                tbTriCycle.Text = priceList[6].ToString("##,###");
                tbTriCycleT.Text = priceList[7].ToString("##,###");
            }
        }
    }
}
