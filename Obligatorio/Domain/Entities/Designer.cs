using System;

namespace Domain.Entities
{
    public class Designer : User
    {
        public Designer(){ }

        public Designer(string username, string password, string name, string surname, DateTime registrationDate, Nullable<DateTime> lastAccess)
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
        public override bool CanSeeOwnedGrids()
        {
            return false;
        }
    }


}
