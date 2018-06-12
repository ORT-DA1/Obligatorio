using System.Collections.Generic;
using Domain.Entities;

namespace Persistance.RepositoryLogic
{
    public class ArchitectRepository
    {
        private ContextDB _context;
        public ArchitectRepository(ContextDB context)
        {
            this._context = context;
        }
        public void AddArchitect(Architect architect)
        {
            _context.Architects.Add(architect);
        }
        public void ModifyArchitect(Architect architectToModify, Designer ModifiedArchitect)
        {
            //TODO
        }
        public void DeleteArchitect(Architect architect)
        {
            _context.Architects.Remove(architect);
        }
        public Architect GetArchitect(Architect architect)
        {
            //TODO
        }
        public List<Architect> GetAllArchitects()
        {
            //TODO
        }
    }
}
