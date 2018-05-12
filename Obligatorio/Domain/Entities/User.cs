using System;
using Domain.Data;

namespace Domain.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Nullable<DateTime> LastAccess { get; set; }
        

        public User (){ }

        public User(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = lastAccess;
        }
        public virtual bool CanABMClients()
        {
            return true;
        }
        public virtual bool CanABMDesigners()
        {
            return true;
        }
        public virtual bool CanABMGrids()
        {
            return true;
        }
        public virtual bool CanSeeOwnedGrids()
        {
            return true;
        }
    }
}
