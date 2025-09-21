using System;

namespace BusinessLogic
{
    public enum enMode
    { 
        Add, 
        Update
    };

    public class clsAppSettings
    {
        public static clsUser CurrentUser = new clsUser(1);
    }
}
