using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using ParkingManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingManager.GUI.Parking
{
    public partial class FrmSignUp : Form
    {
        private ParkingDao parkingDao;
        private List<PriceDto> _priceList;
        public FrmSignUp()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            parkingDao = new ParkingDao();
            List<PriceDto> priceList = parkingDao.GetPriceList();
            if (priceList != null)
                _priceList = priceList;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.Text.Equals("") || tbTicketIdGen.Text.Equals("") || cbArea.SelectedIndex == -1 ||
                cbType.SelectedIndex == -1)
                return;
            if (cbType.SelectedIndex != 0 && tbLicensePlate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập biển kiểm soát!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbLicensePlate.Focus();
                return;
            }

            if (cbType.SelectedIndex == 0)
            {
                tbLicensePlate.Text = "";
            }

            DialogResult dialogResult = MessageBox.Show("Phí giữ xe là: " + _priceList[cbType.SelectedIndex].Price.ToString("###,###") + "đ, \nTiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDto customer = new CustomerDto()
                {
                    AreaID = cbArea.SelectedIndex + 1,
                    Block = tbBlock.Text.Trim(),
                    LicensePlate = tbLicensePlate.Text.Trim(),
                    TicketID = tbTicketIdGen.Text,
                    PhoneNumber = tbPhoneNum.Text.Trim(),
                    IDCard = tbIdCard.Text.Trim(),
                    Name = tbCustomerName.Text,
                    VehicleType = cbType.SelectedIndex + 1,
                    Fee = _priceList[cbType.SelectedIndex]
                };

                if (parkingDao.SignUp(customer) == Constants.RESULT_OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbWarning.Visible = false;
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
                if (thisArea.IsTurnMode)
                    lbWarning.Visible = true;
            }
        }

        private void btnGenTicketId_Click(object sender, EventArgs e)
        {
            string ticketId = parkingDao.GetAvailableTicketId(Constants.MODE_MONTH);
            if (ticketId.Equals(""))
            {
                MessageBox.Show("Hết thẻ xe!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            tbTicketIdGen.Text = ticketId;
        }
    }
}
