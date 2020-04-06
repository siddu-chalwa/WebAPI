using ClientEight.Models;
using System;
using System.Text.RegularExpressions;

namespace ClientEight.Controllers
{
    /// <summary>
    /// class: Validation: contains function DataValidation
    /// </summary>
    public static class ValidationClass
    {
        /// <summary>
        /// function: validate the data entered by the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool DataValidation(User user)
        {
            try
            {
                if (!(Regex.IsMatch(user.Password, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$") && user.Password.Length > 7))
                    return false;
                if (!(Regex.IsMatch(user.UserID, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")))
                    return false;
                if (user.Name.Length <= 6)
                    return false;
                if (!(Regex.IsMatch(user.Name, @"^(_?)([a-zA-Z]+)([ _.-]?)(([a-zA-Z]+)?)$")))
                    return false;
                if (user.Age <= 0 || user.Age > 150)
                    return false;
                if (user.Salary < 500 || user.Salary > 100000000)
                    return false;
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
    }
}
