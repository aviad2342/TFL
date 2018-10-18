using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Utils
{
    static class Alerts
    {
        public static void errorMessage(String msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Boolean checkIfOnlyNumbers(TextBox t)
        {
            int parsedValue;
            if (!int.TryParse(t.Text, out parsedValue))
                return false;
            else return true;
        }
        public static void dataSavedSuccessfully()
        {
            MessageBox.Show("The changes saved successfully in DB!", "Database changed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
