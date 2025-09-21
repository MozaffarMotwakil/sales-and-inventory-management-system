using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class clsValidator
    {
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsValidPhone(string Phone)
        {
            if (string.IsNullOrWhiteSpace(Phone))
            {
                return false;
            }

            if (Phone.Length != 10)
            {
                return false;
            }

            for (int i = 0; i < Phone.Length; i++)
            {
                if (!char.IsDigit(Phone[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
