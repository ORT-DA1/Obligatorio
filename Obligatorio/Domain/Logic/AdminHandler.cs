using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;
using Domain.Entities;

namespace Domain.Logic
{
    public class AdminHandler
    {
        private AdminRepository adminRepository; 
        public AdminHandler()
        {
            this.adminRepository = new AdminRepository();
        }
        public  Administrator GetByUsernameAndPassword(string username, string password)
        {
            if (ExistByUsernameAndPasword(username, password))
            {
                return this.adminRepository.GetAdministratorByUsername(username);
            }
            else
            {
                return null;
            }
        }
        private bool ExistByUsernameAndPasword(String username, String password)
        {
            return this.adminRepository.AdministratorExistsUserNameAndPassword(username, password);
        }
        public Administrator GetByUsername(String username)
        {
            return this.adminRepository.GetAdministratorByUsername(username);
        }
    }
}
             