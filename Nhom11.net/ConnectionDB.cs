using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.net
{
    internal class ConnectionDB
    {
        SqlConnection conn;

        public void openConnection()
        {
            string ckn = @"Server=DESKTOP-0SFRE8R;Database=QuanLyLapTop;Integrated Security=True";
            conn = new SqlConnection(ckn);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        //CRUD
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();
                //Cách 1 nên dùng
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                //Cách 2
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlDataReader dr = cmd.ExecuteReader();
                //dt.Load(dr);
                //dr.Close();
                //cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return dt;
        }

        public DataTable ReadDataWithPmt(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                        cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return dt;
        }

        public void CreateUpdateDelete(string sql, SqlParameter[] sqlParameters = null)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                        cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public bool ExistingMa(string sql, SqlParameter[] sqlParameters = null)
        {
            bool kt = false;
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                        cmd.Parameters.AddRange(sqlParameters);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows) { kt = true; }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                closeConnection();
            }
            return kt;
        }

        public string getFieldValue(string sql)
        {
            string ma = "";
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ma = dr.GetValue(0).ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                closeConnection();
            }
            return ma;
        }
    }
}
