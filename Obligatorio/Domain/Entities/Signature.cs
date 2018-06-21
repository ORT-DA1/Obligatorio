using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "Signatures")]
    public class Signature
    {
        #region PK and FK
        public int SignatureId { get; set; }
        public virtual Grid Grid { get; set; }
        #endregion

        public DateTime Date { get; set; }
        public Architect Architect { get; set; }
        public Signature() { }
        public Signature(Architect architect, DateTime date, Grid grid)
        {
            this.Grid = grid;
            this.Architect = architect;
            this.Date = date;
        }
        public override string ToString()
        {
            string format = "{0} / {1}";
            return String.Format(format, this.Date, this.Architect);
        }

    }
}
