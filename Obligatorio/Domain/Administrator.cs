using System;

namespace Domain
{
    public class Administrator : User
    {
        public Administrator() 
        {

        }

        public Administrator(string username, string password, string name, string surname, DateTime registrationDate, DateTime lastAccess)
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
