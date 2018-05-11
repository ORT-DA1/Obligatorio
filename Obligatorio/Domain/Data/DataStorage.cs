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

        //Storage Methods
        private DataStorage()
        {
            this.Clients = new List<Client>();
            this.Designers = new List<Designer>();
            this.Administrator = new Administrator("admin", "admin", "Joaquin", "Touris", new DateTime(2018, 05, 05), new DateTime(2018, 05, 05));
        }

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

        //Client Methods
        public void SaveClient(Client client)
        {
            storageInstance.Clients.Add(client);
        }

        public void DeleteClient(Client client)
        {
            storageInstance.Clients.Remove(client);
        }

        public void ModifyClient(Client clientToModify, Client modifiedClient)
        {
            Client client = storageInstance.GetClient(clientToModify);
            client.Username = modifiedClient.Username;
            client.Password = modifiedClient.Password;
            client.Name = modifiedClient.Name;
            client.Surname = modifiedClient.Surname;
            client.Id = modifiedClient.Id;
            client.Phone = modifiedClient.Phone;
            client.Address = modifiedClient.Address;
        }

        public Client GetClient(Client clientToFind)
        {
            return storageInstance.Clients.First(client => client.Equals(clientToFind));
        }


        //Designer Methods

        public Designer GetDesigner(Designer designerToFind)
        {
            return storageInstance.Designers.First(designer => designer.Equals(designerToFind));
        }

        public void SaveDesigner(Designer designer)
        {
            this.Designers.Add(designer);
        }

        public void DeleteDesigner(Designer designer)
        {
            this.Designers.Remove(designer);
        }
         
        public void ModifyDesigner(Designer designerToModify, Designer modifiedDesigner)
        {
            Designer designer = storageInstance.GetDesigner(designerToModify);
            designer.Name = modifiedDesigner.Name;
            designer.Surname = modifiedDesigner.Surname;
            designer.Username = modifiedDesigner.Username;
            designer.Password = modifiedDesigner.Password;
        }
    }
}