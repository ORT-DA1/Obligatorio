using System.Collections.Generic;
using Domain.Entities;

namespace Persistance.Interface
{
    public interface IClientRepository
    {
        Client GetClient(Client client);
        void AddClient(Client client);
        void ModifyClient(Client clientToModify, Client ModifiedClient);
        void DeleteClient(Client client);
        List<Client> GetAllClients();
    }
}
