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
        public static readonly int MAX_HEIGHT_IN_PIXELS = 1000;
        public static readonly int MIN_HEIGHT_IN_PIXELS = 0;
        public static readonly int MAX_WIDTH_IN_PIXELS = 1000;
        public static readonly int MIN_WIDTH_IN_PIXELS = 0;


        public static void ValidateUsername(string username)
        {
            if (!IsValidString(username))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_USERNAME);
            }
        }

        public static void ValidatePassword(string password)
        {
            if (!IsValidNumberCharacter(password))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_PASSWORD);
            }
        }

        public static void ValidatePhone(string phone)
        {
            if (!IsValidPhone(phone))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_PHONE);
            }
        }

        private static bool IsValidPhone(string phone)
        {
            Regex expression = new Regex(VALID_NUMBERS);
            if (string.IsNullOrEmpty(phone) || !(expression.IsMatch(phone)))
            {
                return false;
            }

            return true;
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

        public static void ValidateID(string id)
        {
            if (!isValidID(id))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_ID);
            }
        }

        public static void ValidateAddress(string address)
        {
            if (!IsValidNumberCharacterSpace(address))
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_ADDRESS);
            }
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


        private static bool IsValidString(string element)
        {
            Regex expression = new Regex(VALID_CHARACTERS);
            if (string.IsNullOrEmpty(element) || !(expression.IsMatch(element)))
            {
                return false;
            }
            return true;
        }


        private static bool IsValidNumberCharacterSpace(string element)
        {
            Regex expression = new Regex(VALID_NUMBERS_CHARS_AND_SPACE);
            if (string.IsNullOrEmpty(element) || !(expression.IsMatch(element)))
            {
                return false;
            }
            return true;
        }

        private static bool IsValidNumberCharacter(string element)
        {
            Regex expression = new Regex(VALID_NUMBERS_AND_CHARACTERS);
            if (string.IsNullOrEmpty(element) || !(expression.IsMatch(element)))
            {
                return false;
            }
            return true;
        }

        public static void ValidateHeight(int height)
        {
            if (!IsValidHeight(height))
            {
                if (height > MAX_HEIGHT_IN_PIXELS)
                {
                    throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_ABOVE);
                }
                else
                {
                    throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_UNDER);
                }
                
            }
        }

        private static bool IsValidHeight(int height)
        {
            return (height> MIN_HEIGHT_IN_PIXELS && height <= MAX_HEIGHT_IN_PIXELS);
        }

        public static void ValidateWidth(int width)
        {
            if (!IsValidWidth(width))
            {
                if (width > MAX_WIDTH_IN_PIXELS)
                {
                    throw new ExceptionController(ExceptionMessage.GRID_INVALID_WIDTH_ABOVE);
                }
                else
                {
                    throw new ExceptionController(ExceptionMessage.GRID_INVALID_WIDTH_UNDER);
                }
            }
        }

        private static bool IsValidWidth(int width)
        {
            return (width > MIN_HEIGHT_IN_PIXELS && width <= MAX_WIDTH_IN_PIXELS);
        }
    }
}
