using System;
using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.Data
{
    public class DataValidation
    {
        private static readonly string VALID_CHARACTERS = "^[a-zA-Z]*$";
        private static readonly string NUMBERS_AND_CHARACTERS = "^[0-9a-zA-Z]*$";


        public static void UsernameValidate(string username)
        {
            if (!ValidString(username))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_USERNAME);
            }
        }

        public static void NameAndSurnameValidate(string name, string surname)
        {
            if (!ValidString(name))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_NAME);
            }
            if (!ValidString(surname))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_SURNAME);
            }
        }

        public static void PasswordValidate(string password)
        {
            if (!IsValidPassword(password))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_PASSWORD);
            }
        }

        public static bool ValidString(string element)
        {
            Regex expresion = new Regex(VALID_CHARACTERS);
            if (string.IsNullOrEmpty(element) || !(expresion.IsMatch(element)))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(string password)
        {
            Regex expresion = new Regex(NUMBERS_AND_CHARACTERS);
            if (string.IsNullOrEmpty(password) || !(expresion.IsMatch(password)))
            {
                return false;
            }
            return true;
        }
    }
}
