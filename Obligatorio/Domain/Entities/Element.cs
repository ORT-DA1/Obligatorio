using System.Drawing;

namespace Domain.Entities
{
    abstract public class Element
    {
        abstract public void Draw(Graphics graphic);

        abstract public void ModifyCostAndPrice(int Cost, int Price);
    }
}
