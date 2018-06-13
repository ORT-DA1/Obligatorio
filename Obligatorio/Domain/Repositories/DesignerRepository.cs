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
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Designers.Add(designer);
                ctx.SaveChanges();
            }
        }
        public void ModifyDesigner(Designer designer)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Designers.Attach(designer);
                ctx.Entry(designer).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteDesigner(Designer designer)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Designers.Remove(designer);
            }
        }

        public Designer GetDesigner(Designer designerToFind)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Designers.First(designer => designer.Equals(designerToFind));
            }
        }

        public List<Designer> GetAllDesigners()
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Designers.ToList();
            }
        }
    }
}
