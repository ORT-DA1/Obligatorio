using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistance.Interface
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
