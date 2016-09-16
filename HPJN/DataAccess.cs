using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPJN
{
    class DataAccess
    {
        //public static String connstr = "Server=tcp:b768j0aoo4.database.windows.net,1433;Initial Catalog=T1_PA_Leaderboard_DB;Persist Security Info=False;User ID=t1user01;Password=T1password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static String connstr = "server=T1XPS8700X02\\SQLEXPRESS;integrated security=true;database=HPJNDB;connection Timeout=30";
        //public static String connstr = "server=173.3.111.80,1433;integrated security=false;database=HPJNDB;uid=sa;pwd=lokfay;connection Timeout=30";
        public static object GetSingleAnswer(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }

        public static int InsUpDel(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }

        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
