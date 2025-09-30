using System.Text.RegularExpressions;
using DataAccess.Parties;

namespace BusinessLogic.Validation
{
    public static class clsValidator
    {
        public static bool IsNationalNaExists(string nationalNa)
        {
            return clsPersonData.IsNationalNaExists(nationalNa);
        }

        public static bool IsValidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]) && !char.IsWhiteSpace(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

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
