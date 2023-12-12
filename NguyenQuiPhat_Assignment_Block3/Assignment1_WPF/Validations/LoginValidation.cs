using BusinessObjects.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_WPF.Validations
{
    public static class LoginValidation
    {
        public static string Validate(string[] inputs)
        {
            // check email
            if (!Utilities.IsRequired(inputs[0], 6, 50))
                return "Email from 6 to 50";
            else if (!Utilities.IsValidEmail(inputs[0]))
                return "Email is invalid";

            // check password
            if (!Utilities.IsRequired(inputs[1], 6, 50))
                return "Password from 6 to 50";

            return null;
        }
    }
}
