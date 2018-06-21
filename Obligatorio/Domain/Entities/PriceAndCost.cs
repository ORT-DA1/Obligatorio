using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "PricesAndCosts")]
    public class PriceAndCost
    {
        #region PK and FK
        public int PriceAndCostId { get; set; }

        public virtual List<Wall> Wall { get; set; }

        public virtual List<WallBeam> WallBeam { get; set; }

        public virtual List<Window> Window { get; set; }

        public virtual List<Door> Door { get; set; }
        
        public virtual List<DecorativeColumn> DecorativeColumn { get; set; }
        #endregion

        #region Window
        public int Price { get; set; }
        public int Cost { get; set; }
        #endregion
        
    }
}
