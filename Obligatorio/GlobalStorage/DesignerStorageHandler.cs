using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using GlobalStorage.Interface;

namespace GlobalStorage
{
    class DesignerStorageHandler: IGlobalStorageHandler<Designer>
    {

        private DataStorage dataStorage;
        public DesignerStorageHandler()
        {
            this.dataStorage = DataStorage.GetStorageInstance();
        }
        public Designer Get(Designer DesiredDesigner)
        {
            return dataStorage.Designers.First(designer => designer.Equals(DesiredDesigner));
        }

        public List<Designer> GetCollection()
        {
            return dataStorage.Designers;
        }

        public void Save(Designer designer)
        {
            dataStorage.Designers.Add(designer);
        }

        public void Modify(Designer designerToModify , Designer modifiedDesigner)
        {
            Designer designer = Get(designerToModify);
            designer.LastAccess = modifiedDesigner.LastAccess;
            designer.Name = modifiedDesigner.Name;
            designer.Password = modifiedDesigner.Password;
            designer.RegistrationDate = modifiedDesigner.RegistrationDate;
            designer.Surname = modifiedDesigner.Surname;
            designer.Username = modifiedDesigner.Username;
        }

        public void Delete(Designer designer)
        {
            dataStorage.Designers.Remove(designer);
        }

        public bool Exist(Designer designer)
        {
            return dataStorage.Designers.Contains(designer);
        }
    }
}
