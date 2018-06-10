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
        private DBContext context;
        public ClientRepository(DBContext context)
        {
            this.context = context;
        }
        public AddClient(Client client)
        {
            //context.Clients.Add(client);
        }

        public Client GetClient(Client client)
        {
            //TODO
            //Client result = context.Clients.Find(client.ClientID);
            //return (result == null ? Client.NULL : result);
            return new Client();
        }
    }
}
