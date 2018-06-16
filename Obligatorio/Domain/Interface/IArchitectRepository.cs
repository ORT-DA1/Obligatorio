using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IArchitectRepository
    {
        void AddArchitect(Architect architect);
        void ModifyArchitect(Architect architect);
        void DeleteArchitect(Architect architect);
        bool ArchitectExists(Architect architect);
        bool ArchitectExistsUserNameAndPassword(string username, string password);
        Architect GetArchitect(Architect architect);
        Architect GetArchitectByUsername(string username);
        List<Architect> GetAllArchitects();
    }
}
