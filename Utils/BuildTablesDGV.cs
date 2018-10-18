using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HW5.Utils
{
    static class BuildTablesDGV
    {

        private static string conStr = "Data Source=AVIAD-PC\\SQLEXPRESS;Initial Catalog=TFL_HW2;Integrated Security=True";
        public static DataSet readData(string tblName)
        {
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();
                adapter = new SqlDataAdapter("Select * From " + tblName, con);

                adapter.Fill(ds, tblName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Utils.Alerts.errorMessage("Cannot read the database!");
            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return ds;
        }
    }
}
