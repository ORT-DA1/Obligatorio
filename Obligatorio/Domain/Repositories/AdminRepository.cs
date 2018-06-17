using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public class AdminRepository
    {
        public bool AdministratorExistsUserNameAndPassword(string username, string password)
        {
            Administrator adminToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                adminToFind = _context.Administrators.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
            }
            return adminToFind == null ? false : true; 
        }

        public Administrator GetAdministratorByUsername(string username)
        {
            Administrator adminToFind;
            using (DatabaseContext _context = new DatabaseContext())
            {
                adminToFind = _context.Administrators.Where(a => a.Username == username).FirstOrDefault();
            }
            return adminToFind;
        }
    }
}
