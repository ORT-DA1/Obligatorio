using System;

namespace Domain
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegistrationDate { get; set; }
        

        public User ()
        {
            
        }

        public User(string username, string password, string name, string surname, DateTime registrationDate)
        {
            DataValidation.NameAndSurnameValidate(name, surname);
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
        }
       
    }
}
