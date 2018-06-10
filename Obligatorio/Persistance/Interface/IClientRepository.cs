using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistance.Interface
{
    interface IClientRepository
    {
        Client GetClient(Client client);
        void AddClient(Client client);
        void ModifyClient(Client clientToModify, Client ModifiedClient);
        void DeleteClient(Client client);
        List<Client> GetClients();
    }
}
