using System.Collections.Generic;
using System.Linq;
using Domain.Interface;
using Domain.Entities;
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
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Clients.Attach(client);
                _context.Entry(client).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void DeleteClient(Client client)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Clients.Attach(client);
                _context.Clients.Remove(client);
            }
        }
        public bool ClientExists(Client client)
        {
            Client clientToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                clientToFind = _context.Clients.Where(c => c.IdentityCard == client.IdentityCard).FirstOrDefault();
            }
            return !(clientToFind == null);
        }
        public Client GetClient(Client clientToFind)
        {
            using (DatabaseContext _context = new DatabaseContext())
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

        public bool ClientExistsUserNameAndPassword(string username, string password)
        {
            Client clientToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                clientToFind = _context.Clients.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
            }
            return clientToFind == null ? true : false;
        }
        public Client GetClientByUsername(string username)
        {
            Client clientToFind;
            using (DatabaseContext _context = new DatabaseContext())
            {
                clientToFind = _context.Clients.Where(a => a.Username == username).FirstOrDefault();
            }
            return clientToFind;
        }
    }
}
