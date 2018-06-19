using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interface;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class DesignerRepository : IDesignerRepository
    {
        public void AddDesigner(Designer designer)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Designers.Add(designer);
                _context.SaveChanges();
            }
        }
        public void ModifyDesigner(Designer designer)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Designers.Attach(designer);
                _context.Entry(designer).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void DeleteDesigner(Designer designer)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Designers.Attach(designer);
                _context.Designers.Remove(designer);
            }
        }
        public bool DesignerExists(Designer designer)
        {
            Designer designerToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                designerToFind = _context.Designers.Where(d => d.Username == designer.Username && d.DesignerId != designer.DesignerId).FirstOrDefault();
            }
            return !(designerToFind == null);
        }
        public Designer GetDesigner(Designer designerToFind)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.Designers.First(designer => designer.Equals(designerToFind));
            }
        }
        public List<Designer> GetAllDesigners()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.Designers.ToList();
            }
        }
        public bool DesignerExistsUserNameAndPassword(string username, string password)
        {
            Designer designerToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                designerToFind = _context.Designers.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
            }
            return designerToFind == null ? false : true;
        }
        public Designer GetDesignerByUsername(string username)
        {
            Designer designerToFind;
            using (DatabaseContext _context = new DatabaseContext())
            {
                designerToFind = _context.Designers.Where(a => a.Username == username).FirstOrDefault();
            }
            return designerToFind;
        }
    }
}
