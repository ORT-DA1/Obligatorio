using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Data;
using Domain.Interface;
using Domain.Exceptions;

namespace Domain.Logic
{
    public class ClientHandler : IUserHandler<Client>
    {
        private DataStorage storage;
        public ClientHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }

        public Client Get(Client client)
        {
            NotExist(client);
            return this.storage.GetClient(client);
        }
        public void Add(Client client)
        {
            Validate(client);
            Exist(client);
            this.storage.SaveClient(client);
        }
        public void Delete(Client client)
        {
            NotExist(client);
            this.storage.DeleteClient(client);
        }
        public void Modify(Client clientToModify, Client modifiedClient)
        {
            
            NotExist(clientToModify);
            Validate(modifiedClient);
            this.storage.ModifyClient(clientToModify, modifiedClient);
;
            if (!clientToModify.Equals(modifiedClient))
            {
                Exist(modifiedClient);
            }
            this.storage.ModifyClient(clientToModify, modifiedClient);
        }
        public void Exist(Client client)
        {
            if (this.storage.Clients.Contains(client))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }
        public void NotExist(Client client)
        {
            if (!this.storage.Clients.Contains(client))
            {
                throw new ExceptionController(ExceptionMessage.USER_NOT_EXIST);
            }
        }

        public void Validate(Client client)
        {
            DataValidation.ValidateUsername(client.Username);
            DataValidation.ValidatePassword(client.Password);
            DataValidation.ValidateNameAndSurname(client.Name, client.Surname);
            DataValidation.ValidateID(client.Id);
            DataValidation.ValidateAddress(client.Address);
        }
    }

}
