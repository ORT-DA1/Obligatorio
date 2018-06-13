using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(name: "Designers")]
    public class Designer : User
    {
        public int DesignerId { get; set; }
        public Designer(){ }

        public Designer(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.RegistrationDate = registrationDate;
            this.LastAccess = registrationDate;
        }

        public override bool Equals(object designerObject)
        {
            bool isEqual = false;
            if (designerObject != null && this.GetType().Equals(designerObject.GetType()))
            {
                Designer designer = (Designer)designerObject;
                if (this.Username.Equals(designer.Username))
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
