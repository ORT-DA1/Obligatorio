using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Data
{
    public class DataStorage
    {
        /// <summary>
        /// Single reference of the instance
        /// </summary>
        private static DataStorage storageInstance;
        public List<Client> Clients { get; }
        public List<Designer> Designers { get; }
        public Administrator Administrator { get; }


        private DataStorage()
        {
            this.Clients = new List<Client>();
            this.Designers = new List<Designer>();
            this.Administrator = new Administrator("admin", "admin", "Joaquin", "Touris", new DateTime(2018, 05, 05), new DateTime(2018, 05, 05));
        }

        /// <summary> 
        /// Gets the Instance of the GlobalStorage in the system
        /// </summary>
        public static DataStorage GetStorageInstance()
        {
            if (storageInstance == null)
            {
                storageInstance = new DataStorage();
            }

            return storageInstance;
        }

        public void EmptyStorage()
        {
            this.Clients.Clear();
            this.Designers.Clear();
        }

        public Client GetClient(Client clientToFind)
        {
            return this.Clients.First(client => client.Equals(clientToFind));
        }

        public void SaveClient(Client client)
        {
            storageInstance.Clients.Add(client);
        }

        public void DeleteClient(Client client)
        {
            storageInstance.Clients.Remove(client);
        }

        public void ModifyClient()
        {
            throw new NotImplementedException();
        }

    }
}