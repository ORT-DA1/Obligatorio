using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;

namespace Domain.Logic
{
    public class ArchitectHandler
    {
        private DataStorage storage;
        public ArchitectHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }

    }
}
