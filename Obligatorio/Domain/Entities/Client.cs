using System;

namespace Domain.Entities
{
    public class Client : User
    {
        public string Id { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public Client(){ }

        public Client(string username, string password, string name, string surname, string id, int phone, string address, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Phone = phone;
            this.Address = address;
            this.RegistrationDate = registrationDate;
            this.LastAccess = lastAccess;
        }

        public override bool Equals(object clientObject)
        {
            bool isEqual = false;
            if (clientObject != null && this.GetType().Equals(clientObject.GetType()))
            {
                Client client = (Client)clientObject;
                if (this.Id.Equals(client.Id))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }
    }
}
