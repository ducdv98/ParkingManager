using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using ParkingManager.Data.Repositories;
using System;
using System.Windows.Forms;

namespace ParkingManager.GUI.Parking
{
    public partial class PnlGetIn : Form
    {

        private ParkingDao parkingDao;
        private bool turnMode = false;
        private CustomerDto customer;

        public PnlGetIn()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbDate.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            tbTime.Text = DateTime.Now.ToShortTimeString();

            parkingDao = new ParkingDao();
        }

        private void btnModeTurn_Click(object sender, EventArgs e)
        {
            turnMode = true;
            pnCustomerInfo.Enabled = false;
            btnGenTicketId.Enabled = true;
            tbTicketIdInput.Enabled = false;
            tbLicensePlate.Enabled = true;
            pnOption.Enabled = true;

            tbBlock.Text = "";
            tbCustomerName.Text = "";
            tbLicensePlate.Text = "";
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            turnMode = false;
            customer = null;
            cbArea.SelectedIndex = -1;
            tbBlock.Text = "";
            tbCustomerName.Text = "";
            tbLicensePlate.Text = "";
            tbLicensePlate.Enabled = false;
            tbTicketIdGen.Text = "";
            tbTicketIdInput.Text = "";
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            btnGenTicketId.Enabled = false;
            tbTicketIdInput.Enabled = true;
            btnExtendTerm.Visible = false;
            tbDate.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            tbTime.Text = DateTime.Now.ToShortTimeString();
            lbWarning.Visible = false;
            pnOption.Enabled = false;
            lbAvailable.Text = "0";
            lbTotal.Text = "0";
        }

        private void btnGenTicketId_Click(object sender, EventArgs e)
        {
            string ticketId = parkingDao.GetAvailableTicketId(Constants.MODE_TURN);
            if (ticketId.Equals(""))
            {
                MessageBox.Show("Hết thẻ xe!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            tbTicketIdGen.Text = ticketId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (turnMode)
            {
                if (cbArea.SelectedIndex == -1 || cbType.SelectedIndex == -1 || tbTicketIdGen.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhâp đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                TicketForTurnModeDto ticket = new TicketForTurnModeDto()
                {
                    AreaID = cbArea.SelectedIndex + 1,
                    ID = tbTicketIdGen.Text,
                    LicensePlate = tbLicensePlate.Text,
                    VehicleType = cbType.SelectedIndex + 1
                };
                int result = parkingDao.GetInToParkingTurnMode(ticket);

                if (result == Constants.RESULT_OK)
                    btnRefresh_Click(null, null);
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!\nKhu vực đã hết chỗ!", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            else
            {
                if (tbTicketIdInput.Text.Equals("") || tbCustomerName.Text.Equals(""))
                {
                    return;
                }

                if (btnExtendTerm.Visible)
                {
                    MessageBox.Show("Gia hạn trước khi vào bãi!", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int result = parkingDao.GetInToParkingTermMode(tbTicketIdInput.Text.Trim());
                    if (result == Constants.RESULT_OK)
                        btnRefresh_Click(null, null);
                    else
                        MessageBox.Show("Có lỗi xảy ra!\nKhu vực đã hết chỗ!", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
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
                if (turnMode && !thisArea.IsTurnMode)
                    lbWarning.Visible = true;
            }
        }

        private void tbTicketIdInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !tbTicketIdInput.Text.Equals(""))
            {
                customer = parkingDao.GetCustomerInforTurnIn(tbTicketIdInput.Text);
                if (customer != null)
                {
                    tbCustomerName.Text = customer.Name;
                    tbBlock.Text = customer.Block;
                    tbLicensePlate.Text = customer.LicensePlate;
                    cbType.SelectedIndex = customer.VehicleType - 1;
                    cbArea.SelectedIndex = customer.AreaID - 1;
                    cbStatus.SelectedIndex = (customer.Status) ? 0 : 1;
                }
                else
                {
                    MessageBox.Show("Thẻ xe không tồn tại hoặc xe đã ở trong bãi!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnRefresh_Click(null, null);
                }
            }

        }

        private void tbTicketIdInput_TextChanged(object sender, EventArgs e)
        {
            customer = null;
            cbArea.SelectedIndex = -1;
            tbBlock.Text = "";
            tbCustomerName.Text = "";
            tbLicensePlate.Text = "";
            tbLicensePlate.Enabled = false;
            tbTicketIdGen.Text = "";
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            btnGenTicketId.Enabled = false;
            btnExtendTerm.Visible = false;
            tbTicketIdInput.Enabled = true;
            tbDate.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            tbTime.Text = DateTime.Now.ToShortTimeString();
            lbWarning.Visible = false;
            pnOption.Enabled = false;
            lbAvailable.Text = "0";
            lbTotal.Text = "0";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
                btnExtendTerm.Visible = true;
            else if (cbStatus.SelectedIndex == 0)
                btnExtendTerm.Visible = false;
        }

        private void btnExtendTerm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Phí giữ xe là: " + customer.Fee.Price.ToString("###,###") + "đ, \nTiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (parkingDao.ExtendTerm(tbTicketIdInput.Text.Trim()) == Constants.RESULT_OK)
                {
                    cbStatus.SelectedIndex = 0;
                    MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnRegisterMember_Click(object sender, EventArgs e)
        {
            FrmSignUp register = new FrmSignUp();
            DialogResult dr = register.ShowDialog();
        }
    }
}
