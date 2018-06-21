using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GeneratedDoor
    {
        public int GeneratedDoorId { get; set; }
        public virtual Architect Architect { get; set; }

    }
}
