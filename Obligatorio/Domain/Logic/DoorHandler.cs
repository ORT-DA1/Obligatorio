using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class DoorHandler : IElementHandler<Door>
    {
        private IDoorRepository doorRepository;
        public void Add(Door door)
        {
            this.doorRepository.AddDoor(door);
        }

    }
}
