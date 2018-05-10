using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Data;
using Domain.Interface;

namespace Domain.Logic
{
    public class ClientHandler : IUserHandler<Client>
    {
        private DataStorage storage;
        public ClientHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }
        public void Add(Client client)
        {
            Validate(client);
            Exist(client);
            this.storage.SaveClient(client);
        }
        public void Delete(Client client)
        {
            this.storage.DeleteClient(client);

        }
        public void Modify(Client clientToModify, Client modifiedClient)
        {
            this.storage.ModifyClient();

        }
        public void Exist(Client client)
        {
            if (storage.Clients.Contains(client))
            {
                throw new Exception();
            }
        }

        public void Validate(Client client)
        {
            DataValidation.ValidateUsername(client.Username);
            DataValidation.ValidatePassword(client.Password);
            DataValidation.ValidateNameAndSurname(client.Name, client.Surname);
            DataValidation.ValidateID(client.Id);
            DataValidation.ValidateAddress(client.Address);
            //DataValidation.ValidatePhone(client.Phone);
        }
        public Client Get(Client client)
        {
            //Validate before returning this.
            return this.storage.GetClient(client);
        }

        //No estoy seguro de esto, no se si deberia devolver false o una exception.
    }

}
