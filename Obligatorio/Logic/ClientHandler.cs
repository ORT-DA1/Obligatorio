using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Logic
{
    public class ClientHandler
    {
        public static void AddClient(Client client)
        {

            DataValidation.NameAndSurnameValidate(client.Name, client.Surname);
        }
    }
}
