using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.VisualBasic;

namespace HW5.Utils
{
    static class InputValidation
    {
        public static Boolean isLetters(TextBox str)
        {
            return Regex.IsMatch(str.Text, "[a-zA-Z]+");
        }

        public static Boolean checkLength(int length, TextBox str)
        {
            if (str.Text.Length > length)
            {
                return false;
            }
            return true;
        }

        public static Boolean checkStringLength(int length, String str)
        {
            if (str.Length > length)
            {
                return false;
            }
            return true;
        }

        public static Boolean isStringLetters(TextBox str)
        {
            return Regex.IsMatch(str.Text, "[a-zA-Z]+");
        }

        public static Boolean checkIfLetters(TextBox t)
        {
            if (Regex.IsMatch(t.Text, @"^[a-zA-Z0-9# ]+$") && !Regex.IsMatch(t.Text, "^\\d[^<]+"))
                return true;
            else return false;
        }

        public static Boolean isNumbersLetters(TextBox t)
        {
            if ((Regex.IsMatch(t.Text, @"^[a-zA-Z0-9# ]+$") || Regex.IsMatch(t.Text, "^[0-9]$")) && !Regex.IsMatch(t.Text, "^\\d[^<]+"))
                return true;
            else return false;
        }
        public static Boolean isNumbers(TextBox t)
        {
            int n;
            if (int.TryParse(t.Text, out n))
                return true;
            else return false;
        }
        public static Boolean checkIfStringLetters(String t)
        {
            if (Regex.IsMatch(t, @"^[a-zA-Z0-9# ]+$") && !Regex.IsMatch(t, "^\\d[^<]+"))
                return true;
            else return false;
        }

        public static Boolean isNumeric(TextBox str)
        {
            return Information.IsNumeric(str.Text);  
        }

        public static Boolean isPositiveNumeric(TextBox str)
        {
            int i = 0;
            if(isNumeric(str))
            {
              i = Convert.ToInt16(str.Text);
              if (i > 0)
              {
                  return true;
              }
              else
              {
                  return false;
              }
            }
            else
            {
                return false;
            }
        }

        public static Boolean isStringNumeric(String str)
        {
            return Information.IsNumeric(str);
        }

        public static Boolean isStringPositiveNumeric(String str)
        {
            int i = 0;
            if (isStringNumeric(str))
            {
                i = Convert.ToInt16(str);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        // check dates
        public static int checkDates(DateTimePicker start, DateTimePicker end)
        {
            int diff = start.Value.CompareTo(end.Value);
            if (diff == 0)
            {
                return 0;
            }
            else if (diff > 0)
            {
                return 1;
            }
            return -1;
        }
        // check file size
        public static bool ValidFile(string filename)
        {
            long limitSize = 1048576;
            var fileSizeInBytes = new FileInfo(filename).Length;
            if (fileSizeInBytes > limitSize)
                return false;
            return true;
        }
    }
}
