using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistance.Interface;
using Domain.Entities;

namespace Persistance.RepositoryLogic
{
    public class ClientRepository: IClientRepository
    {
        private ContextDB context;
        public ClientRepository(ContextDB context)
        {
            this.context = context;
        }
        public void AddClient(Client client)
        {
            context.Clients.Add(client);
        }

        public Client GetClient(Client client)
        {
            return context.Clients.Find(client.Id);
        }
    }
}
