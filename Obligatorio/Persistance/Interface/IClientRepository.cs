using System.Collections.Generic;
using Domain.Entities;

namespace Persistance.Interface
{
    public interface IClientRepository
    {
        void AddClient(Client client);
        void ModifyClient(Client clientToModify, Client ModifiedClient);
        void DeleteClient(Client client);
        Client GetClient(Client client);
        List<Client> GetAllClients();
    }
}
