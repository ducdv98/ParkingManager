using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManager.Data.Repositories
{
    public class CustomerDao
    {
        public CustomerDao()
        {
        }

        public List<CustomerDto> GetCustomers()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_all_customer", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    List<CustomerDto> customers = new List<CustomerDto>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerDto customer = new CustomerDto()
                            {
                                ID = (int)reader["MaKH"],
                                Name = (string)reader["TenKH"],
                                PhoneNumber = (string)reader["SDT"],
                                IDCard = (string)reader["CMND"],
                                Block = (string)reader["ToaNha"],
                                LicensePlate = (reader["BKS"] == DBNull.Value) ? "" : (string)reader["BKS"],
                                TicketID = (string)reader["MaTheXe"],
                                Status = (bool)reader["TrangThai"],
                                IsParking = (bool)reader["XeDangOTrongBai"]
                            };
                            customers.Add(customer);
                        }
                    }

                    return customers;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public int DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_delete_customer", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                    cmd.Parameters.Add(new SqlParameter("@customerId", customerId));

                    int rowEffected = cmd.ExecuteNonQuery();
                    if (rowEffected != 0)
                        return Constants.RESULT_OK;
                    return Constants.RESULT_ERROR;
                }
                catch (Exception e)
                {
                    return Constants.RESULT_ERROR;
                }
            }
        }
    }
}