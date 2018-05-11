using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class ExceptionMessage
    {
        public const string USER_INVALID_USERNAME = "El Username es incorrecto. No puede ser vacio ni contener numeros o caracteres especiales.";
        public const string USER_INVALID_PASSWORD = "La contrasena es incorrecta. No puede ser vacia y un minimo de caracteres 5 caracteres.";
        public const string USER_INVALID_NAME = "El nombre del usuario es incorrecto. No puede ser vacío ni contener numeros o caracteres especiales.";
        public const string USER_INVALID_SURNAME = "El apellido del usuario es incorrecto. No puede ser vacío ni contener numeros o caracteres especiales.";
        public const string USER_INVALID_ID = "La cédula no puede ser vacía. Debe ser un numero y no debe incluir letras o caracteres especiales.";
        public const string USER_INVALID_ADDRESS = "La Direccion no puede ser vacia. Porfavor ingrese una.";
        public const string USER_INVALID_PHONE = "El Telefono es incorrecto. Debe ser un numero y no debe incluir letras o caracteres especiales.";
        public const string USER_NOT_EXIST = "Ese usuario no existe.";
        public const string USER_ALREADY_EXSIST = "Ese usuario ya existe";
    }
}
