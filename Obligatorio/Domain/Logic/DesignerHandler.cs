using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Entities;
using Domain.Interface;
using Domain.Exceptions;


namespace Domain.Logic
{
    public class DesignerHandler: IUserHandler<Designer>
    {
        private DataStorage storage;
        public DesignerHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }

        public Designer Get(Designer designer)
        {
            Exist(designer);
            return this.storage.GetDesigner(designer);
        }

        public void Add(Designer designer)
        {
            Validate(designer);
            Exist(designer);
            this.storage.SaveDesigner(designer);
        }

        public void Delete(Designer designer)
        {
            NotExist(designer);
            this.storage.DeleteDesigner(designer);
        }

        public void Modify(Designer designerTomodify, Designer modifiedDesigner)
        {
            NotExist(designerTomodify);
            Validate(modifiedDesigner);
            if (!designerTomodify.Equals(modifiedDesigner))
            {
                Exist(modifiedDesigner);
            }
            this.storage.ModifyDesigner(designerTomodify, modifiedDesigner);
        }


        public void Exist(Designer designer)
        {
            if (this.storage.Designers.Contains(designer))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }

        public void NotExist(Designer designer)
        {
            if (!this.storage.Designers.Contains(designer))
            {
                throw new ExceptionController(ExceptionMessage.USER_NOT_EXIST);
            }
        }

        public void Validate(Designer designer)
        {
            DataValidation.ValidateNameAndSurname(designer.Name, designer.Surname);
            DataValidation.ValidateUsername(designer.Username);
            DataValidation.ValidatePassword(designer.Password);
        }
    }
}
