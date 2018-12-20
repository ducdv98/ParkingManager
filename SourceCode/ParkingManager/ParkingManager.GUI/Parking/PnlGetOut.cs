using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using ParkingManager.Data.Repositories;
using System.Windows.Forms;

namespace ParkingManager.GUI.Parking
{
    public partial class PnlGetOut : Form
    {
        private ParkingDao parkingDao;
        private CustomerDto customer;

        public PnlGetOut()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            parkingDao = new ParkingDao();
        }

        private void tbTicketIdInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !tbTicketIdInput.Text.Equals(""))
            {
                customer = parkingDao.GetCustomerInforTurnOut(tbTicketIdInput.Text);
                if (customer != null)
                {
                    if (customer.Name != null)
                    {
                        tbCustomerName.Text = customer.Name;
                        tbBlock.Text = customer.Block;
                        cbStatus.SelectedIndex = (customer.Status) ? 0 : 1;
                    }

                    tbLicensePlate.Text = customer.LicensePlate ?? "";
                    cbType.SelectedIndex = customer.VehicleType - 1;
                    cbArea.SelectedIndex = customer.AreaID - 1;
                    tbFee.Text = customer.Fee.Price.ToString("###,###");
                }
                else
                {
                    MessageBox.Show("Thẻ xe không tồn tại hoặc xe đã ở trong bãi!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnRefresh_Click(null, null);
                }
            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            customer = null;
            tbTicketIdInput.Text = "";
            cbArea.SelectedIndex = -1;
            tbBlock.Text = "";
            tbCustomerName.Text = "";
            tbLicensePlate.Text = "";
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            tbFee.Text = "";
            btnExtendTerm.Visible = false;
        }

        private void tbTicketIdInput_TextChanged(object sender, System.EventArgs e)
        {
            cbArea.SelectedIndex = -1;
            tbBlock.Text = "";
            tbCustomerName.Text = "";
            tbLicensePlate.Text = "";
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            tbFee.Text = "";
            btnExtendTerm.Visible = false;
        }

        private void cbStatus_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
                btnExtendTerm.Visible = true;
            else if (cbStatus.SelectedIndex == 0)
                btnExtendTerm.Visible = false;
        }

        private void btnExtendTerm_Click(object sender, System.EventArgs e)
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
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            if (btnExtendTerm.Visible)
            {
                MessageBox.Show("Gia hạn thẻ xe trước khi xuất bến!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            bool mode = (tbCustomerName.Text.Equals(""));
            if (mode)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Phí giữ xe là: " + customer.Fee.Price.ToString("###,###") + "đ, \nTiếp tục?",
                        "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (parkingDao.GetOutParking(tbTicketIdInput.Text.Trim(), mode) == Constants.RESULT_OK)
                    {
                        btnRefresh_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (parkingDao.GetOutParking(tbTicketIdInput.Text.Trim(), mode) == Constants.RESULT_OK)
                    btnRefresh_Click(null, null);
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
    }
}
