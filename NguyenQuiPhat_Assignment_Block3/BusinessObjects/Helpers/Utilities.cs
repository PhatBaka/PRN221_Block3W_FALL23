using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObjects.Helpers
{
    public class Utilities
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                return true;
            }
            return false;
        }
        public static bool IsValidBirthday(string input)
        {
            if (DateTime.TryParse(input, out DateTime birthday))
            {
                // Check if the parsed date is not in the future (optional)
                if (birthday.Date <= DateTime.Today)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsRequired(string input, int min, int max)
        {
            if (input.Length >= min && input.Length <= max)
                return true;
            return false;
        }
        public static bool IsInt(string text)
        {
            if (int.TryParse(text, out int result))
                return true;
            return false;
        }
        public static bool IsDecimal(string text)
        {
            if (decimal.TryParse(text, out decimal result))
                return true;
            return false;
        }
        public static bool CheckYear(string year)
        {
            if (int.Parse(year) < DateTime.Now.Year)
                return true;
            return false;
        }
    }
}
