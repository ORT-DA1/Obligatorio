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
        bool ClientNotExists(Client client);
        Client GetClient(Client client);
        List<Client> GetAllClients();
    }
}
