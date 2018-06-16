using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;
using Domain.Repositories;
using Domain.Exceptions;

namespace Domain.Logic
{
    public class ArchitectHandler: IUserHandler<Architect>
    {
        private IArchitectRepository architectRepository;
        public ArchitectHandler()
        {
            this.architectRepository = new ArchitectRepository();
        }
        public void Add(Architect architect)
        {
            Validate(architect);
            Exist(architect);
            this.architectRepository.AddArchitect(architect);
        }
        public void Modify(Architect architect)
        {
            NotExist(architect);
            Validate(architect);
            this.architectRepository.ModifyArchitect(architect);
        }
        public void Delete(Architect architect)
        {
            NotExist(architect);
            this.architectRepository.DeleteArchitect(architect);
        }
        public void Exist(Architect architect)
        {
            if (this.architectRepository.ArchitectExists(architect))
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        }
        public void Validate(Architect architect)
        {
            DataValidation.ValidateUsername(architect.Username);
            DataValidation.ValidatePassword(architect.Password);
            DataValidation.ValidateNameAndSurname(architect.Name, architect.Surname);
        }
        public void NotExist(Architect architect)
        {
            if (!this.architectRepository.ArchitectExists(architect))
            {
                throw new ExceptionController(ExceptionMessage.USER_NOT_EXIST);
            }
        }
        public Architect Get(Architect architect)
        {
            NotExist(architect);
            return this.architectRepository.GetArchitect(architect);
        }
        public List<Architect> GetList()
        {
            List<Architect> architectList = this.architectRepository.GetAllArchitects();
            IsNotEmpty(architectList);
            return architectList;
        }
        public void IsNotEmpty(List<Architect> architectList)
        {
            if (!architectList.Any())
            {
                throw new ExceptionController(ExceptionMessage.EMPTY_ARCHITECT_LIST);
            }
        }
        public bool ExistsUserName(String username)
        {
            if (this.architectRepository.Arc)
            {

            }
        }

    }
}
