using System.Collections.Generic;
using Domain.Entities;

namespace Persistance.Interface
{
    public interface IDesignerRepository
    {
        Designer GetDesigner(Designer designer);
        void AddDesigner(Designer designer);
        void ModifyDesigner(Designer designerToModify, Designer ModifiedDesigner);
        void DeleteDesigner(Designer designer);
        List<Designer> GetAllDesigners();
    }
}
