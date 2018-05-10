using System;
using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.Data
{
    public class DataValidation
    {
        private static readonly string VALID_CHARACTERS = "^[a-zA-Z]*$";
        private static readonly string VALID_NUMBERS_AND_CHARACTERS = "^[0-9a-zA-Z]*$";
        private static readonly string VALID_NUMBERS = "^[0-9]*$";
        private static readonly string VALID_NUMBERS_CHARS_AND_SPACE = "^[0-9a-zA-Z ]*$";
        private static readonly int VALID_USER_ID_LENGTH = 8;
        

        public static void ValidateUsername(string username)
        {
            if (!IsValidString(username))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_USERNAME);
            }
        }

        public static void ValidatePassword(string password)
        {
            if (!IsValidPassword(password))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_PASSWORD);
            }
        }

        public static void ValidateNameAndSurname(string name, string surname)
        {
            if (!IsValidString(name))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_NAME);
            }
            if (!IsValidString(surname))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_SURNAME);
            }
        }

        internal static void ValidateID(string id)
        {
            if (!isValidID(id))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_ID);
            }
        }

        //internal static void ValidatePhone(int phone)
        //{
        //    if (isValidPhone)
        //    {

        //    }
        //}

        internal static void ValidateAddress(string address)
        {
            if (!IsValidAddress(address))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_ADDRESS);
            }
        }

        private static bool IsValidAddress(string address)
        {
            Regex expression = new Regex(VALID_NUMBERS_CHARS_AND_SPACE);
            if (string.IsNullOrEmpty(address) || !(expression.IsMatch(address)))
            {
                return false;
            }

            return true;
        }

        private static bool isValidID(string id)
        {
            Regex expression = new Regex(VALID_NUMBERS);
            if (string.IsNullOrEmpty(id) || !(expression.IsMatch(id)) || !IsValidIdLength(id))
            {
                return false;
            }

            return true;
        }

        private static bool IsValidIdLength(string id)
        {
            return id.Length == VALID_USER_ID_LENGTH;
        }

        public static bool IsValidString(string element)
        {
            Regex expression = new Regex(VALID_CHARACTERS);
            if (string.IsNullOrEmpty(element) || !(expression.IsMatch(element)))
            {
                return false;
            }
            return true;
        }


        public static bool IsValidPassword(string password)
        {
            Regex expression = new Regex(VALID_NUMBERS_AND_CHARACTERS);
            if (string.IsNullOrEmpty(password) || !(expression.IsMatch(password)))
            {
                return false;
            }
            return true;
        }


    }
}
