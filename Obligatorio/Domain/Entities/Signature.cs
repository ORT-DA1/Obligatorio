using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Signature
    {
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
