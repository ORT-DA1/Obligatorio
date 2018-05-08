using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public class DesignerHandler
    {
        public static void AddDesigner(Designer designer)
        {
            DataValidation.UsernameValidate(designer.Username);
            DataValidation.PasswordValidate(designer.Password);
            DataValidation.NameAndSurnameValidate(designer.Name, designer.Surname);
        }
    }
}
