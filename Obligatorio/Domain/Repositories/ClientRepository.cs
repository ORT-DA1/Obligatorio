using System.Collections.Generic;
using System.Linq;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;

namespace Domain.Repositories
{
    public class ClientRepository: IClientRepository
    {
        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
        }

        public void ModifyClient(Client clientToModify, Client modifiedClient)
        {
            //TODO
        }
        public void DeleteClient(Client client)
        {
            //Me conviene hacer borrado logico?
            _context.Clients.Remove(client);
        }

        public Client GetClient(Client client)
        {
            NotExist(client);
            return _context.Clients.First(client => client.Equals(clientToFind));
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
