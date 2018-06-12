using System.Collections.Generic;
using System.Linq;
using Persistance.Interface;
using Domain.Entities;

namespace Persistance.RepositoryLogic
{
    public class ClientRepository: IClientRepository
    {
        private ContextDB _context;
        public ClientRepository(ContextDB context)
        {
            this._context = context;
        }
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
            //Hay que hacer algo mas? Como puedo hacer borrado logico?
            _context.Clients.Remove(client);
        }

        public Client GetClient(Client client)
        {
            //Funciona con client.Id?
            return _context.Clients.Find(client.Id);
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
