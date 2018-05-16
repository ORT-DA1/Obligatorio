using Domain.Data;
using Domain.Entities;
using Domain.Interface;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;

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
            NotExist(designer);
            return this.storage.GetDesigner(designer);
        }

        public void Add(Designer designer)
        {
            Validate(designer);
            Exist(designer);
            this.storage.SaveDesigner(designer);
        }

        public void Validate(Designer designer)
        {
            DataValidation.ValidateNameAndSurname(designer.Name, designer.Surname);
            DataValidation.ValidateUsername(designer.Username);
            DataValidation.ValidatePassword(designer.Password);
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
        public List<Designer> GetList()
        {
            List<Designer> designersList = storage.Designers;
            IsNotEmpty(designersList);
            return designersList;
        }
        private void IsNotEmpty(List<Designer> designersList)
        {
            if (!designersList.Any())
            {
                throw new ExceptionController(ExceptionMessage.EMPTY_DESIGNERS_LIST);
            }
        }
    }
}
