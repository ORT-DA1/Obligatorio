using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Data;
using Domain.Interface;
using Domain.Exceptions;
using Domain.Repositories;
using System;

namespace Domain.Logic
{
    public class ClientHandler : IUserHandler<Client>
    {
        private IClientRepository clientRepository;
        public ClientHandler()
        {
            this.clientRepository = new ClientRepository();
        }

        public void Add(Client client)
        {
            Validate(client);
            Exist(client);
            this.clientRepository.AddClient(client);
        }

        public void Modify(Client client)
        {
            NotExist(client);
            Validate(client);
            this.clientRepository.ModifyClient(client);
        }

        public void Delete(Client client)
        {
            NotExist(client);
            this.clientRepository.DeleteClient(client);
        }

        public void Exist(Client client)
        {
            if (this.clientRepository.ClientExists(client))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }

        public Client Get(Client client)
        {
            NotExist(client);
            return this.clientRepository.GetClient(client);
            
        }

        public List<Client> GetList()
        {
            List<Client> clientList = clientRepository.GetAllClients();
            IsNotEmpty(clientList);
            return clientList;
        }

        public void Validate(Client client)
        {
            DataValidation.ValidateUsername(client.Username);
            DataValidation.ValidatePassword(client.Password);
            DataValidation.ValidateNameAndSurname(client.Name, client.Surname);
            DataValidation.ValidateID(client.IdentityCard);
            DataValidation.ValidatePhone(client.Phone);
            DataValidation.ValidateAddress(client.Address);
        }
        public void LookForUser(String username, String password)
        {
            //TODO
        }

        public void NotExist(Client client)
        {
            if (!this.clientRepository.ClientExists(client))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }
        private void IsNotEmpty(List<Client> clientList)
        {
            if (!clientList.Any())
            {
                throw new ExceptionController(ExceptionMessage.EMPTY_CLIENTS_LIST);
            }
        }
    }
}
