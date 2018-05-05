using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Administrator : User
    {
        public String IdentityCard { get; set; }
        public int Phone { get; set; }
        public String Address { get; set; }
        public DateTime LastAccess { get; set; }

        public Administrator() 
        {

        }

        public Administrator(string username, string password, string name, string surname, DateTime registrationDate)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
        }
    }

    
}
