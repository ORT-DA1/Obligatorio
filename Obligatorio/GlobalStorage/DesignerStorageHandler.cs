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
            return this.dataStorage.Designers.First(designer => designer.Equals(DesiredDesigner));
        }

    }
}
