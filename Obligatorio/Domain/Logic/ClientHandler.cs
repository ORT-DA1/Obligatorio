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
            Exist(client);
            Validate(client);
            this.clientRepository.ModifyClient(client);
        }

        public void Delete(Client client)
        {
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
        public Client GetByUsernameAndPassword(String username, String password)
        {
            if (ExistByUsernameAndPasword(username, password))
            {
                return this.clientRepository.GetClientByUsername(username);
            }
            else
            {
                return null;
            }
        }
        private bool ExistByUsernameAndPasword(string username, string password)
        {
            return this.clientRepository.ClientExistsUserNameAndPassword(username, password);
        }
        public Client GetByUsername(String username)
        {
            return this.clientRepository.GetClientByUsername(username);
        }
        public bool boolExist(Client client)
        {
            return this.clientRepository.ClientExists(client) ? true : false;
        }
    }

}
