using System;
using System.Text.RegularExpressions;

namespace Domain.Data
{
    public class DataValidation
    {
        private const string VALID_CHARS = "^[a-zA-Z]*$";

        public static void NameAndSurnameValidate(string name, string surname)
        {
            if (!ValidString(name))
            {
                throw new Exception();
            }
            if (!ValidString(surname))
            {
                throw new Exception();
            }
        }

        public static void UsernameValidate(string username)
        {
            if (!ValidString(username))
            {
                throw new Exception();
            }
        }

        public static void PasswordValidate(string password)
        {
            if (!ValidString(password))
            {
                throw new Exception();
            }
        }

        public static bool ValidString(string element)
        {
            bool isValid = true;
            Regex expresion = new Regex(VALID_CHARS);
            if (string.IsNullOrEmpty(element) || !(expresion.IsMatch(element)))
            {
                isValid= false;
            }
            return isValid;
        }
    }
}
