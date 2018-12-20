using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using ParkingManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParkingManager.GUI.Customer
{
    public partial class FrmCustomer : Form
    {
        private CustomerDao customerDao;
        private List<CustomerDto> dataSource;

        public FrmCustomer()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            customerDao = new CustomerDao();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dataSource = customerDao.GetCustomers();
            dgvCustomer.DataSource = dataSource;
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!tbSearch.Text.Equals(""))
            {
                string key = tbSearch.Text.ToLower();
                var filterResult = dataSource.Where(c =>
                    c.Name.ToLower().Contains(key) || c.IDCard.ToLower().Contains(key) || c.PhoneNumber.ToLower().Contains(key) ||
                    c.LicensePlate.ToLower().Contains(key)).ToList();

                dgvCustomer.DataSource = filterResult;
                dgvCustomer.Refresh();
            }
            else
            {
                dgvCustomer.DataSource = dataSource;
                dgvCustomer.Refresh();
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                CustomerDto customer = dgvCustomer.SelectedRows[0].DataBoundItem as CustomerDto;
                DialogResult dialogResult = MessageBox.Show("Xoá khách hàng [ " + customer.Name + " ] ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (customerDao.DeleteCustomer(customer.ID) == Constants.RESULT_OK)
                    {
                        RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


            }
        }

        private void RefreshDataSource()
        {
            dgvCustomer.DataSource = null;
            dataSource = customerDao.GetCustomers();
            dgvCustomer.DataSource = dataSource;
            dgvCustomer.Refresh();
        }
    }
}