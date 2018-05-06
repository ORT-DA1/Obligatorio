using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalStorage.Interface;
using Domain;

namespace GlobalStorage
{
    public class ClientStorageHandler: IGlobalStorageHandler<Client>
    {
        private DataStorage dataStorage;

        public ClientStorageHandler()
        {
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        public Client Get(Client desiredClient)
        {
            return dataStorage.Clients.First(client => client.Equals(desiredClient));
        }
        public List<Client> GetCollection()
        {
            return dataStorage.Clients;
        }
        public void Save(Client client)
        {
            this.dataStorage.Clients.Add(client);
        }
        public void Modify(Client clientToModify, Client modifiedClient)
        {
            Client client = Get(clientToModify);
            client.Name = modifiedClient.Name;
            client.Password = modifiedClient.Password;
            client.Phone = modifiedClient.Phone;
            client.Username = modifiedClient.Username;
            client.IdentityCard = modifiedClient.IdentityCard;
            client.Surname = modifiedClient.Surname;
            client.LastAccess = modifiedClient.LastAccess;
            client.RegistrationDate = modifiedClient.RegistrationDate;
        }
        public void Delete(Client client)
        {
            dataStorage.Clients.Remove(client);
        }
        public bool Exist(Client client)
        {
            return dataStorage.Clients.Contains(client);
        }

    }
}
