using System.Collections.Generic;
using System.Linq;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public void AddClient(Client client)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }

        public void ModifyClient(Client client)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Clients.Attach(client);
                ctx.Entry(client).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteClient(Client client)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Clients.Remove(client);
            }
        }
        
        public Client GetClient(Client clientToFind)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Clients.First(client => client.Equals(clientToFind));
            }
        }

        public List<Client> GetAllClients()
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Clients.ToList();
            }
        }
    }
}
