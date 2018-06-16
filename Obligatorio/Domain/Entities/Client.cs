using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(name: "Clients")]
    public class Client : User
    {
        public int ClientId { get; set; }
        public string IdentityCard { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client(){ }

        public Client(string username, string password, string name, string surname, string IdentityCard, string phone, string address, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            //this.Id = id;
            this.Phone = phone;
            this.Address = address;
            this.RegistrationDate = registrationDate;
            this.LastAccess = registrationDate;
        }

        public override bool Equals(object clientObject)
        {
            bool isEqual = false;
            if (clientObject != null && this.GetType().Equals(clientObject.GetType()))
            {
                Client client = (Client)clientObject;
                if (this.IdentityCard.Equals(client.IdentityCard) || this.Username.Equals(client.Username))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }
        public override bool CanABMClients()
        {
            return false;
        }
        public override bool CanABMDesigners()
        {
            return false;
        }
        public override bool CanABMGrids()
        {
            return false;
        }
        public override bool CanVerifyInformation()
        {
            if (this.LastAccess == null)
            {
                return true;
            }
           return false;
        }
        public override bool CanConfigurePrices()
        {
            return false;
        }
        public override bool CanABMArchitects()
        {
            return false;
        }
    }
}
