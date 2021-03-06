﻿using System;

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
            this.LastAccess = registrationDate;
        }
        public virtual bool CanABMClients()
        {
            return true;
        }
        public virtual bool CanABMDesigners()
        {
            return true;
        }
        public virtual bool CanABMArchitects()
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
        public virtual bool CanVerifyInformation()
        {
            return true;
        }
        public virtual bool CanConfigurePrices()
        {
            return true;
        }
        public virtual bool CanSeePersonalInformation()
        {
            return true;
        }
        public virtual bool CanSignGrids()
        {
            return false;
        }
        public virtual bool CanCreateNewElements()
        {
            return false;
        }
        public override string ToString()
        {
            string format = "{0} - {1} {2}";
            return String.Format(format, this.Username, this.Name, this.Surname);
        }
    }
}
