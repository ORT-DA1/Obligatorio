using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GeneratedWindow
    {
        public int GeneratedWindowId { get; set; }
        public float Width { get; set; }
        public float High { get; set; }
        public string Name { get; set; }
        public virtual PriceAndCost PriceAndCost { get; set; }
        public virtual Architect Architect { get; set; }
    }
}
