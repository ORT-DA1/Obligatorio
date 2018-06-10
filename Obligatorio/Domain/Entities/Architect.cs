using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Architect: User
    {
        public Architect() { }

        public Architect(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = lastAccess;
        }

        public override bool Equals(object designerObject)
        {
            bool isEqual = false;
            if (designerObject != null && this.GetType().Equals(designerObject.GetType()))
            {
                Architect architect = (Architect)designerObject;
                if (this.Username.Equals(architect.Username))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }

        public override bool CanABMClients()
        {
            return false;
        }
        public override bool CanABMDesigners()
        {
            return false;
        }
        public override bool CanABMArchitects()
        {
            return false;
        }
        public override bool CanSeeOwnedGrids()
        {
            return false;
        }
        public override bool CanVerifyInformation()
        {
            return false;
        }
        public override bool CanConfigurePrices()
        {
            return false;
        }
        public override bool CanSeePersonalInformation()
        {
            return false;
        }
    }
}
