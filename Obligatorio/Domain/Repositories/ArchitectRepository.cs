using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repositories
{
    public class ArchitectRepository : IArchitectRepository
    {
        public void AddArchitect(Architect architect)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Architects.Add(architect);
                ctx.SaveChanges();
            }
        }
        public void ModifyArchitect(Architect architect)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Architects.Attach(architect);
                ctx.Entry(architect).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void DeleteArchitect(Architect architect)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Architects.Remove(architect);
            }
        }
        public Architect GetArchitect(Architect architectToFind)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Architects.First(architect => architect.Equals(architectToFind));
            }
        }
        public List<Architect> GetAllArchitects()
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                return ctx.Architects.ToList();
            }
        }
    }
}
