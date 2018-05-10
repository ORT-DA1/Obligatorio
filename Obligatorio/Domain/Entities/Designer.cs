using System;

namespace Domain.Entities
{
    public class Designer : User
    {
        public Designer(){ }

        public Designer(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = lastAccess;
        }
    }
}
