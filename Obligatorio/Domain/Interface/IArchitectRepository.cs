using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IArchitectRepository
    {
        void AddArchitect(Architect architect);
        void ModifyArchitect(Architect architectToModify, Designer ModifiedArchitect);
        void DeleteArchitect(Architect architect);
        Architect GetArchitect(Architect architect);
        List<Architect> GetAllArchitects();
    }
}
