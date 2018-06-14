using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Domain.Entities
{
    //[Table(name: "Elements")]
    abstract public class Element
    {
       // public int ElementId { get; set; }

        public string name = "defecto";
        abstract public void Draw(Graphics graphic);

        abstract public void ModifyCostAndPrice(int Cost, int Price);
    }
}
