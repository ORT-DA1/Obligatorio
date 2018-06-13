using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(name: "Administrators")]
    public class Administrator : User
    {
        public int AdministratorId { get; set; }
        public Administrator() { }
        public Administrator(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = registrationDate;
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
