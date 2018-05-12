using System;

namespace Domain.Entities
{
    public class Administrator : User
    {
        public Administrator() { }
        public Administrator(string username, string password, string name, string surname, DateTime registrationDate, DateTime lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = lastAccess;
        }

        public override bool CanCreateGrid()
        {
            return false;
        }
        public override bool CanSeeOwnedGrids()
        {
            return false;
        }
    }

    
}
