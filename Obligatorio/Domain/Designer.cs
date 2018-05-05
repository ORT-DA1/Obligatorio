using System;

namespace Domain
{
    public class Designer : User
    {
        public DateTime LastAccess { get; set; }

        public Designer()
        {

        }

        public Designer(string username, string password, string name, string surname, DateTime registrationDate)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
        }
    }
}
