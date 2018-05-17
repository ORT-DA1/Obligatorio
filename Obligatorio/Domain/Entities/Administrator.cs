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

        public override bool CanSeeOwnedGrids()
        {
            return false;
        }
        public override bool CanABMGrids()
        {
            return false;
        }
        public override bool CanVerifyInformation()
        {
            return false;
        }
        public override bool CanSeePersonalInformation()
        {
            return false;
        }
    }

    
}
