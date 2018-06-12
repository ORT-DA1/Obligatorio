using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Persistance.Interface;

namespace Persistance.RepositoryLogic
{
    public class DesignerRepository: IDesignerRepository
    {
        private ContextDB _context;

        public DesignerRepository(ContextDB context)
        {
            this._context = context;
        }
        public void AddDesigner(Designer designer)
        {
            _context.Designers.Add(designer);
        }

        public void ModifyDesigner(Designer designerToModify, Designer ModifiedDesigner)
        {
            //TODO
        }
        public void DeleteDesigner(Designer designer)
        {
            _context.Designers.Remove(designer);
        }

        public Designer GetDesigner(Designer designer)
        {
            //Funciona con designer.Id?
            return _context.Designers.Find(designer.id);
        }
        public List<Designer> GetAllDesigners()
        {
            return _context.Designers.ToList();
        }

    }
}
