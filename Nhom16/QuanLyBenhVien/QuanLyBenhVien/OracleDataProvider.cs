using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace QuanLyBenhVien
{
    public class OracleDataProvider
    {
        public static OracleConnection conn = null;

        public static string stringConnection(string host, int port, string sid, string user, string password)
        {
            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;

            return connString;
        }
        public static void Connect(string connect)
        {
            try
            {
                // MessageBox.Show(connect);
                conn = new OracleConnection();
                conn.ConnectionString = connect;
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        public static void DisConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Dispose();
            }
        }
        public static void DisConnect1(OracleConnection conn1)
        {
            if (conn1.State == ConnectionState.Open)
            {
                conn1.Close();
            }
            else
            {
                conn1.Dispose();
            }

        }
        public static int ExcuteQuery(string query)
        {
            int result = -1;
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return result;
        }

        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return dt;
        }
        public static DataTable GetDataTableWithoutDisConnect(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                // DisConnect();
            }
            return dt;
        }
    }
}
