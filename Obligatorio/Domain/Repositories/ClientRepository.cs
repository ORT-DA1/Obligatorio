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
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Clients.Add(client);
                _context.SaveChanges();
            }
        }

        public void ModifyClient(Client client)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Clients.Attach(client);
                _context.Entry(client).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void DeleteClient(Client client)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Clients.Attach(client);
                _context.Clients.Remove(client);
            }
        }
        public bool ClientExists(Client client)
        {
            
        }
        
        public Client GetClient(Client clientToFind)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.Clients.First(client => client.Equals(clientToFind));
            }
        }

        public List<Client> GetAllClients()
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.Clients.ToList();
            }
        }

        public List<Client> GetAllClients2()
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                var query = from client in _context.Clients where client.Name == "Joahn" select client;

                //En el select, le puedo poner select new {client.Name} y 
                //me trae todos los clientes con ese nombre y solo el nombre no el obj entero.
               // Client client = query.SingleOrDefault();
                return query.ToList();
                 
                foreach (Client client2 in query)
                {
                    //Aca hago algo con cada client.
                }
            }
        }
    }
}
