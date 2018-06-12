using System.Collections.Generic;
using Domain.Entities;

namespace Persistance.Interface
{
    public interface IDesignerRepository
    {
      
        void AddDesigner(Designer designer);
        void ModifyDesigner(Designer designerToModify, Designer ModifiedDesigner);
        void DeleteDesigner(Designer designer);
        Designer GetDesigner(Designer designer);
        List<Designer> GetAllDesigners();
    }
}
