 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace GlobalStorage
{
    public class DataStorage
    {
        private static DataStorage storageInstance;
        public List<Client> Clients { get; }
        public List<Designer> Designers { get; }


        private DataStorage()
        {
            this.Clients = new List<Client>();
            this.Designers = new List<Designer>();
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
    }
}
