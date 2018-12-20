using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManager.Data.Repositories
{
    public class StatistiscDao
    {
        public StatistiscDao()
        {
        }

        public RevenueDto GetRevenue(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_get_revenue", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.Add(new SqlParameter("@date", date));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            RevenueDto revenue = new RevenueDto()
                            {
                                RevenueFromTurnMode = (decimal)reader["DoanhThuTuGuiLuot"],
                                RevenueFromTermMode = (decimal)reader["DoanhThuTuGuiThang"],
                                TotalRevenue = (decimal)reader["TongDoanhThu"]
                            };
                            return revenue;
                        }

                        return null;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public int[] GetNumberOfTicket()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("get_number_of_ticket", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        int[] value = new int[2];
                        value[0] = (int)reader["TongSoVe"];
                        reader.NextResult();
                        reader.Read();
                        value[1] = (int)reader["DaPhatRa"];
                        return value;
                    }

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
