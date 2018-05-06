using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logica
{
    public class ClientHandler
    {
        public static void AddClient(Client client)
        {
            DataValidation.UsernameValidate(client.Name);
            DataValidation.PasswordValidate(client.Password);
            DataValidation.NameAndSurnameValidate(client.Name, client.Surname);
        }
    }

}
