using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5
{
    public class globals
    {
        private String LogedInUser;

        private String LogedInUserID;

        private DateTime LastVisit;

        private static string[] colors = { "Blue", "White", "Aqua", "Azure", "Black", "Brown", "Cyan", "Grey", "Green", "Gold", "Yellow", "Red", "Indigo", "Ivory", "Navy", "Orange", "Pink", "Plum", "Purple", "Silver", "LightBlue" };

        private static globals gl;

        public static globals getGlobals()
        {
            if (gl == null)
            {
                try
                {
                    gl = new globals();
                }
                catch (Exception)
                {
                }
            }
            return gl;
        }

        public string GetLogedInUser()
        {
            return this.LogedInUser;
        }

        public void SetLogedInUser(string u)
        {
            this.LogedInUser = u;
        }
        public string GetLogedInUserID()
        {
            return this.LogedInUserID;
        }

        public void SetLogedInUserID(string u)
        {
            this.LogedInUserID = u;
        }
        public DateTime GetUserLastVisit()
        {
            return this.LastVisit;
        }

        public void SettUserLastVisit(DateTime u)
        {
            this.LastVisit = u;
        }
    }
}
