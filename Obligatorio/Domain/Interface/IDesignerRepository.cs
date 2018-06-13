using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IDesignerRepository
    {
      
        void AddDesigner(Designer designer);
        void ModifyDesigner(Designer designer);
        void DeleteDesigner(Designer designer);
        Designer GetDesigner(Designer designer);
        List<Designer> GetAllDesigners();
    }
}
