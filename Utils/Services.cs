using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HW5.Utils
{
    class Services
    {
        private static string[] colors = {"Blue","White","Aqua","Azure","Black","Brown","Cyan","Grey","Green","Gold","Yellow","Red","Indigo","Ivory","Navy","Orange","Pink","Plum","Purple","Silver","LightBlue"};

        private static SqlCommand dataCommand = new SqlCommand();

        public static void fillComboBox(ComboBox cb,string query, string proertyName,Form mainWindow,Form currentWindow)
        {
            dataCommand.Connection = SQLConnection.con;
            string sdads = query + " order by " + proertyName;
            dataCommand.CommandText = (query + " order by " + proertyName);
            SQLConnection.con.Open();

            try
            {
                SqlDataReader reader = dataCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb.Items.Add(reader.GetValue(0));
                    }
                    dataCommand.Dispose();
                    reader.Close();
                    cb.SelectedIndex = -1;
                }
                else
                {
                    cb.Items.Add("Sorry no " + proertyName + " available");
                    dataCommand.Dispose();
                    reader.Close();
                    return;
                }
            }
            catch (SqlException s)
            {             
                MessageBox.Show(s.ToString());
                return;
            }
            finally { SQLConnection.con.Close(); }

        }

        public static void fillComboBoxI(ComboBox cb, string query, string proertyName)
        {
            dataCommand.Connection = SQLConnection.con;
            string sdads = query + " order by " + proertyName;
            dataCommand.CommandText = (query + " order by " + proertyName);
            SQLConnection.con.Open();

            try
            {
                SqlDataReader reader = dataCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb.Items.Add(reader.GetValue(0));
                    }
                    dataCommand.Dispose();
                    reader.Close();
                    cb.SelectedIndex = -1;
                }
                else
                {
                    dataCommand.Dispose();
                    reader.Close();
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.ToString());
            }
            finally { SQLConnection.con.Close(); }

        }

        public static void fillListBox(ListBox lb, string query, string proertyName, Form mainWindow, Form currentWindow)
        {
            dataCommand.Connection = SQLConnection.con;
            string sdads = query + " order by " + proertyName;
            dataCommand.CommandText = (query + " order by " + proertyName);
            SQLConnection.con.Open();

            try
            {
                SqlDataReader reader = dataCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lb.Items.Add(reader.GetValue(0));
                    }
                    dataCommand.Dispose();
                    reader.Close();
                    lb.SelectedIndex = -1;
                }
                else
                {
                    Utils.Alerts.errorMessage("No " + proertyName + " in the DB, Please fill " + proertyName + " first!");
                    dataCommand.Dispose();
                    reader.Close();
                    mainWindow.Enabled = true;
                    currentWindow.Dispose();
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.ToString());
            }
            finally { SQLConnection.con.Close(); }

        }
        public static String[] getColors()
        {
            return colors;
            }

    }
}
