using ParkingManager.Data.Common;
using ParkingManager.Data.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManager.Data.Repositories
{
    public class LoginDao
    {
        public LoginDao() { }

        public StaffDto Login(string username, string password)
        {
            string passwordHashed = Encryptor.MD5Hash(password);

            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("usp_login", connection) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@password", passwordHashed));
                    var returnParam = cmd.Parameters.Add("@count", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;


                    cmd.ExecuteNonQuery();
                    int result = (int)returnParam.Value;

                    if (result != 0)
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            StaffDto staff = new StaffDto();
                            staff.ID = (int)reader["MaNV"];
                            staff.Name = (string)reader["TenNV"];
                            staff.IDCardNumber = (string)reader["CMND"];
                            staff.PhoneNumber = (string)reader["SDT"];
                            staff.Roll = (string)reader["TenCV"];
                            staff.Role = (int)reader["PhanQuyen"];
                            return staff;
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

        public void ResetStatusForAllUser()
        {
            if (DateTime.Now.Day == 1)
            {
                using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("usp_reset_status_for_all_user", connection) { CommandType = CommandType.StoredProcedure };

                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                    }
                }
            }
        }
    }
}
