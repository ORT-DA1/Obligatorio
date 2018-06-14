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
        public int SignatureId { get; set; }
        public DateTime Date { get; set; }
        public Architect Architect { get; set; }

        public Signature() { }
        public Signature(Architect architect, DateTime date)
        {
            this.Architect = architect;
            this.Date = date;
        }

    }
}
