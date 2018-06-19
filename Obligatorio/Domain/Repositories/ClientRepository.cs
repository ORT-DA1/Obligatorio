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
                var contactToDelete = _context.Clients.Where(c => (c.IdentityCard == client.IdentityCard || c.Username == client.Username) && c.ClientId == client.ClientId).FirstOrDefault();
                _context.Clients.Remove(contactToDelete);
                _context.SaveChanges();
            }
        }
        public bool ClientExists(Client paramClient)
        {
            Client clientToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                clientToFind = _context.Clients.Where(c => (c.IdentityCard == paramClient.IdentityCard || c.Username == paramClient.Username) && c.ClientId != paramClient.ClientId).FirstOrDefault();
            }
            return !(clientToFind == null);
        }
        public Client GetClient(Client clientToFind)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.Clients.Where(c => (c.IdentityCard == clientToFind.IdentityCard || c.Username == clientToFind.Username) && c.ClientId != clientToFind.ClientId).FirstOrDefault();
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
            return clientToFind == null ? false : true;
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
