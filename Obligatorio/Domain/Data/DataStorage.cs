using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Data
{
    public class DataStorage
    {
        private static DataStorage storageInstance;
        private List<User> Users;
        public List<Client> Clients { get; }
        public List<Designer> Designers { get; }
        public Administrator Administrator { get; }
        public List<Grid> Grids { get; }

        //Storage Methods
        private DataStorage()
        {
            this.Users = new List<User>();
            this.Clients = new List<Client>();
            this.Designers = new List<Designer>();
            this.Grids = new List<Grid>();
            this.Administrator = new Administrator("admin", "admin", "Joaquin", "Touris", new DateTime(2018, 05, 05), new DateTime(2018, 05, 05));
        }

        public void Initialize()
        {
            this.Users.Add(Administrator);
            this.GenerateDesigners();
            this.GenerateClients();
        }

        private void GenerateDesigners()
        {
            DateTime validDate = new DateTime(2018, 05, 28, 10, 53, 55);
            Designer firstDesigner = new Designer("donald", "donald123", "Donald", "Trump", validDate, null);
            Designer secondDesigner = new Designer("slash", "guitarLover1", "Slash", "Jackson", validDate, null);

            this.Designers.Add(firstDesigner);
            this.Designers.Add(secondDesigner);

            this.Users.Add(firstDesigner);
            this.Users.Add(secondDesigner);
        }
        private void GenerateClients()
        {
            DateTime validDate = new DateTime(2018, 05, 28, 10, 53, 55);
            Client firstClient = new Client("Netsuite", "12345", "Oracle", "Netsuite", "12345678",234234234 , "16 de Abril 1912", validDate, null);
            Client secondClient = new Client("Lol", "lol123", "League", "of Legends", "54683928", 234234234, "16 de Abril 1912", validDate, null);

            this.Clients.Add(firstClient);
            this.Clients.Add(secondClient);

            this.Users.Add(firstClient);
            this.Users.Add(secondClient);
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
            this.Users.Clear();
        }

        public void UserExist(string userName, string password)
        {
            bool userFound = false;
            foreach (var user in this.Users)
            {
                if (user.Username.Equals(userName) && user.Password.Equals(password))
                {
                    userFound = true;
                }
            }

            if (!userFound)
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_PASSWORD);
            }
        }

        public User GetUser(string username)
        {
            return this.Users.Find(user => user.Username.Equals(username));
        }

        //Client Methods
        public void SaveClient(Client client)
        {
            storageInstance.Clients.Add(client);
            storageInstance.Users.Add(client);
        }

        public void DeleteClient(Client client)
        {
            storageInstance.Clients.Remove(client);
            storageInstance.Users.Remove(client);
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

            this.Users.Remove(clientToModify);
            this.Users.Add(modifiedClient);
        }

        public Client GetClient(Client clientToFind)
        {
            return storageInstance.Clients.First(client => client.Equals(clientToFind));
        }
        
        public Grid GetGrid(Client client)
        {
            return this.Grids.First(grid => grid.Client.Equals(client));
        }

        public void SaveGrid(Grid grid)
        {
            storageInstance.Grids.Add(grid);
        }

        public void DeleteGrid(Grid grid)
        {
            storageInstance.Grids.Remove(grid);
        }


        //Designer Methods

        public Designer GetDesigner(Designer designerToFind)
        {
            return storageInstance.Designers.First(designer => designer.Equals(designerToFind));
        }

        public void SaveDesigner(Designer designer)
        {
            this.Designers.Add(designer);
            this.Users.Add(designer);
        }

        public void DeleteDesigner(Designer designer)
        {
            this.Designers.Remove(designer);
            this.Users.Remove(designer);
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