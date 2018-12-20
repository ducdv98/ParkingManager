using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManager.Data.Repositories
{
    public class ParkingDao
    {
        public ParkingDao()
        {
        }

        public string GetAvailableTicketId(int mode)
        {
            bool modeT = (mode == Constants.MODE_MONTH);
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_available_ticket_id", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@mode", modeT));
                    var ticketId = "";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        ticketId = (string)reader["MaTheXe"];
                    }

                    return ticketId;
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        public AreaDto GetInformationAboutArea(int id)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_infor_of_area", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    AreaDto area = new AreaDto();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        area.MaxVolume = (int)reader["SL_ToiDa"];
                        area.Available = (int)reader["SL_ConTrong"];
                        area.IsTurnMode = (bool)reader["ChoPhepGuiLuot"];
                    }

                    return area;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public int GetInToParkingTurnMode(TicketForTurnModeDto ticket)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_in_turn_mode", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticket.ID));
                    cmd.Parameters.Add(new SqlParameter("@licsenPlate", ticket.LicensePlate));
                    cmd.Parameters.Add(new SqlParameter("@time", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@areaId", ticket.AreaID));
                    cmd.Parameters.Add(new SqlParameter("@vehicleType", ticket.VehicleType));
                    var returnParam = cmd.Parameters.Add("@result", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();
                    int result = (int)returnParam.Value;

                    if (result != 0)
                        return Constants.RESULT_OK;
                    return Constants.RESULT_ERROR;

                }
                catch (Exception e)
                {
                    return Constants.RESULT_ERROR;
                }
            }
        }

        public int GetInToParkingTermMode(string ticketId)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_in_term_mode", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticketId));


                    int result = cmd.ExecuteNonQuery();
                    if (result != 0)
                        return Constants.RESULT_OK;
                    return Constants.RESULT_ERROR;

                }
                catch (Exception e)
                {
                    return Constants.RESULT_ERROR;
                }
            }
        }

        public CustomerDto GetCustomerInforTurnIn(string ticketId)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_customer_infor", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticketId));
                    cmd.Parameters.Add(new SqlParameter("@mode", false));
                    var returnParam = cmd.Parameters.Add("@count", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;


                    cmd.ExecuteNonQuery();
                    int result = (int)returnParam.Value;

                    if (result == 2)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            CustomerDto customer = new CustomerDto()
                            {
                                LicensePlate = (reader["BKS"] == DBNull.Value) ? "" : (string)reader["BKS"],
                                Name = (string)reader["TenKH"],
                                IDCard = (string)reader["CMND"],
                                PhoneNumber = (string)reader["SDT"],
                                Block = (string)reader["ToaNha"],
                                VehicleType = (int)reader["MaLoai"],
                                AreaID = (int)reader["MaKhu"]
                            };

                            reader.NextResult();
                            reader.Read();
                            customer.Status = (bool)reader["TrangThai"];

                            reader.NextResult();
                            reader.Read();
                            customer.Fee = new PriceDto() { ID = (int)reader["MaMP"], Price = (decimal)reader["MucPhi"] };
                            return customer;
                        }
                    }

                    return null;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public CustomerDto GetCustomerInforTurnOut(string ticketId)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_customer_infor", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticketId));
                    cmd.Parameters.Add(new SqlParameter("@mode", true));
                    var returnParam = cmd.Parameters.Add("@count", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;


                    cmd.ExecuteNonQuery();
                    int result = (int)returnParam.Value;

                    if (result == 1)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            CustomerDto customer = new CustomerDto()
                            {
                                LicensePlate = (reader["BKS"] == DBNull.Value) ? "" : (string)reader["BKS"],
                                VehicleType = (int)reader["LoaiXe"],
                                AreaID = (int)reader["KhuVuc"],
                                Fee = new PriceDto() { ID = (int) reader["MaMP"], Price = (decimal) reader["MucPhi"]}
                            };
                            return customer;
                        }
                    }

                    if (result == 2)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            CustomerDto customer = new CustomerDto()
                            {
                                LicensePlate = (reader["BKS"] == DBNull.Value) ? "" : (string)reader["BKS"],
                                Name = (string)reader["TenKH"],
                                IDCard = (string)reader["CMND"],
                                PhoneNumber = (string)reader["SDT"],
                                Block = (string)reader["ToaNha"],
                                VehicleType = (int)reader["MaLoai"],
                                AreaID = (int)reader["MaKhu"]
                            };

                            reader.NextResult();
                            reader.Read();
                            customer.Status = (bool)reader["TrangThai"];

                            reader.NextResult();
                            reader.Read();
                            customer.Fee = new PriceDto() { ID = (int)reader["MaMP"], Price = (decimal)reader["MucPhi"] };
                            return customer;
                        }
                    }

                    return null;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public int ExtendTerm(string ticketId)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_extend_term", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticketId));

                    int result = cmd.ExecuteNonQuery();

                    if (result != 0)
                        return Constants.RESULT_OK;

                    return Constants.RESULT_ERROR;
                }
                catch (Exception e)
                {
                    return Constants.RESULT_ERROR;
                }
            }
        }

        public List<PriceDto> GetPriceList()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_price_list", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@mode", true));

                    List<PriceDto> priceList = new List<PriceDto>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PriceDto price = new PriceDto();
                            price.ID = (int)reader["MaMP"];
                            price.Price = (decimal)reader["MucPhi"];
                            priceList.Add(price);
                        }
                    }

                    return priceList;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public int SignUp(CustomerDto customer)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_register_customer", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@name", customer.Name));
                    cmd.Parameters.Add(new SqlParameter("@licensePlate", customer.LicensePlate));
                    cmd.Parameters.Add(new SqlParameter("@idCard", customer.IDCard));
                    cmd.Parameters.Add(new SqlParameter("@phoneNum", customer.PhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@block", customer.Block));
                    cmd.Parameters.Add(new SqlParameter("@vehicleType", customer.VehicleType));
                    cmd.Parameters.Add(new SqlParameter("@areaId", customer.AreaID));
                    cmd.Parameters.Add(new SqlParameter("@ticketId", customer.TicketID));
                    cmd.Parameters.Add(new SqlParameter("@feeId", customer.Fee.ID));


                    int rowEffected = cmd.ExecuteNonQuery();


                    if (rowEffected == 3)
                        return Constants.RESULT_OK;
                    return Constants.RESULT_ERROR;

                }
                catch (Exception e)
                {
                    return Constants.RESULT_ERROR;
                }
            }
        }

        public int GetOutParking(string ticketId, bool mode)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_out_of_parking", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@ticketId", ticketId));
                    cmd.Parameters.Add(new SqlParameter("@mode", mode));
                    
                    int rowEffected = cmd.ExecuteNonQuery();

                    if (rowEffected >= 2)
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