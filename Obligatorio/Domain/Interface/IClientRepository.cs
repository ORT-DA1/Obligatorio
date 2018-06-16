using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IClientRepository
    {
        void AddClient(Client client);
        void ModifyClient(Client client);
        void DeleteClient(Client client);
        bool ClientExists(Client client);
        bool ClientExistsUserNameAndPassword(string username, string password);
        Client GetClient(Client client);
        Client GetClientByUsername(string username);
        List<Client> GetAllClients();
    }
}
