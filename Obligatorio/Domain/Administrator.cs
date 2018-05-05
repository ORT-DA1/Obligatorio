using System;

namespace Domain
{
    public class Administrator : User
    {
        public DateTime LastAccess { get; set; }

        public Administrator() 
        {

        }

        public Administrator(string username, string password, string name, string surname, DateTime registrationDate)
        {
            this.NameAndSurnameValidate(username, surname);
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
        }
    }

    
}
