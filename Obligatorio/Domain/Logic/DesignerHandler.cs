using Domain.Data;
using Domain.Entities;
using Domain.Interface;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;
using Domain.Interface;
using Domain.Repositories;
using System;

namespace Domain.Logic
{
    public class DesignerHandler: IUserHandler<Designer>
    {
        private IDesignerRepository designerRepository;
        public DesignerHandler()
        {
            this.designerRepository = new DesignerRepository();
        } 
        public Designer Get(Designer designer)
        {
            NotExist(designer);
            return this.designerRepository.GetDesigner(designer);
        }
        public void Add(Designer designer)
        {
            Validate(designer);
            Exist(designer);
            this.designerRepository.AddDesigner(designer);
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
            this.designerRepository.DeleteDesigner(designer);
        }
        public void Modify(Designer designer)
        {
            NotExist(designer);
            Validate(designer);
            this.designerRepository.ModifyDesigner(designer);
        }
        public void Exist(Designer designer)
        {
            if (this.designerRepository.DesignerExists(designer))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }
        public void NotExist(Designer designer)
        {
            if (!this.designerRepository.DesignerExists(designer))
            {
                throw new ExceptionController(ExceptionMessage.USER_NOT_EXIST);
            }
        }
        public List<Designer> GetList()
        {
            List<Designer> designersList = this.designerRepository.GetAllDesigners();
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

        public Designer GetByUsernameAndPassword(string username, string password)
        {
            if (ExistByUsernameAndPasword(username, password))
            {
                return this.designerRepository.GetDesignerByUsername(username);
            }
            else
            {
                return null;
            }
        }

        private bool ExistByUsernameAndPasword(string username, string password)
        {
            return this.designerRepository.DesignerExistsUserNameAndPassword(username, password);
        }

        public bool boolExist(Designer designer)
        {
            if (this.designerRepository.DesignerExists(designer))
            {
                return true;
            }
            return false;
        }
    }
}
