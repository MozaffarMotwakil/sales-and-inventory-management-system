﻿using System;

namespace BusinessLogic.Users
{
    public class clsUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public clsUser(int userID)
        {
            UserID = userID;
            UserName = "Mozaffar_Mo";
        }

        public static clsUser Find(int userID)
        {
            if (userID < 1)
            {
                return null;
            }

            return new clsUser(1);
        }

    }
}
