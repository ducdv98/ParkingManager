using ParkingManager.Data.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManager.Data.Repositories
{
    public class SettingDao
    {
        public SettingDao() { }

        public List<decimal> GetPriceList()
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
                    cmd.Parameters.Add(new SqlParameter("@mode", false));

                    List<decimal> priceList = new List<decimal>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            priceList.Add((decimal)reader["MucPhi"]);
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

        public int UpdatePriceList(List<decimal> priceList)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd =
                        new SqlCommand("usp_update_price_list", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                    cmd.Parameters.Add(new SqlParameter("@pBikeTurn", priceList[0]));
                    cmd.Parameters.Add(new SqlParameter("@pBikeTerm", priceList[1]));
                    cmd.Parameters.Add(new SqlParameter("@pEBikeTurn", priceList[2]));
                    cmd.Parameters.Add(new SqlParameter("@pEBikeTerm", priceList[3]));
                    cmd.Parameters.Add(new SqlParameter("@pMBikeTurn", priceList[4]));
                    cmd.Parameters.Add(new SqlParameter("@pMBikeTerm", priceList[5]));
                    cmd.Parameters.Add(new SqlParameter("@pTBikeTurn", priceList[6]));
                    cmd.Parameters.Add(new SqlParameter("@pTBikeTerm", priceList[7]));

                    int rowEffected = cmd.ExecuteNonQuery();
                    if (rowEffected == 8)
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
