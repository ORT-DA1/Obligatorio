using System;

namespace Domain
{
    public class Client : User
    {
        public String IdentityCard { get; set; }
        public int Phone { get; set; }
        public String Address { get; set; }
        public DateTime LastAccess { get; set; }
        public bool FirstJoin { get; set; }

        public Client()
        {

        }

        public Client(string username, string password, string name, string surname, string identityCard, int phone, string address, DateTime registrationDate)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.IdentityCard = identityCard;
            this.Phone = phone;
            this.Address = address;
            this.RegistrationDate = registrationDate;
        }
    }
}
