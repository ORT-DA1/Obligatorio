using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Logic.Interface;
using GlobalStorage.Interface;
using GlobalStorage;

namespace Logic
{
    public class ClientHandler: IUserHandler<Client>
    {
        private IGlobalStorageHandler<Client> storageHandler;
        public ClientHandler()
        {
            this.storageHandler = new ClientStorageHandler();
        }
        public void Add(Client client)
        {
            Validate(client);
            Exist(client);
            this.storageHandler.Save(client);
        }
        public void Delete(Client client)
        {

        }
        public void Modify(Client clientToModify, Client modifiedClient)
        {

        } 
        public void Exist(Client client)
        {
            if (storageHandler.Exist(client))
            {
                //Throw exception for existing client
            }
        }

        public void Validate(Client client)
        {
            DataValidation.UsernameValidate(client.Username);
            DataValidation.PasswordValidate(client.Password);
            DataValidation.NameAndSurnameValidate(client.Name, client.Surname);
        }
        public Client Get(Client client)
        {
            //Validate before returning this.
            return this.storageHandler.Get(client);
        }

        //No estoy seguro de esto, no se si deberia devolver false o una exception.
        public bool ValidateLogin(string userName, string password)
        {
            var clients = this.storageHandler.GetCollection();
            foreach (var client in clients)
            {
                if (client.Username.Equals(userName) && client.Password.Equals(password))
                {
                    return true;
                }
            }
            
            return true;
        }
    }

}
