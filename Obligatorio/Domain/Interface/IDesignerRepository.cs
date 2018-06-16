using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IDesignerRepository
    {
      
        void AddDesigner(Designer designer);
        void ModifyDesigner(Designer designer);
        void DeleteDesigner(Designer designer);
        bool DesignerExists(Designer designer);
        bool DesignerExistsUserNameAndPassword(string username, string password);
        Designer GetDesigner(Designer designer);
        Designer GetDesignerByUsername(string username);
        List<Designer> GetAllDesigners();
    }
}
