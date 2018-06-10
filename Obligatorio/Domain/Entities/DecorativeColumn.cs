using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DecorativeColumn : Element
    {
        public Point UbicationPoint { get; set; }
        private SolidBrush wallBeamBrush;
        public float width = 0.50f;
        public static float MINIMUM_WIDTH = 0.85f;
        public static int MINIMUM_WIDTH_IN_PIXELS = 9;
        public static Tuple<int, int> CostPriceDecorativeColumn = new Tuple<int, int>(25, 50);

        public DecorativeColumn(Point ubicationPoint)
        {
            this.UbicationPoint = ubicationPoint;
            this.wallBeamBrush = new SolidBrush(Color.Violet);
        }

        public override void ModifyCostAndPrice(int Cost, int Price)
        {
            CostPriceDecorativeColumn = new Tuple<int, int>(Cost, Price);
        }

        public override void Draw(Graphics graphic)
        {
            Rectangle rectangle = new Rectangle(this.UbicationPoint.X - 5, this.UbicationPoint.Y - 5, (int)width, (int)width);
            float startAngle = 0;
            float sweepAngle = 360;
            graphic.FillPie(wallBeamBrush, rectangle, startAngle, sweepAngle);
        }

        public override bool Equals(object decorativeColumnObject)
        {
            bool isEqual = false;
            if (decorativeColumnObject != null && this.GetType().Equals(decorativeColumnObject.GetType()))
            {
                WallBeam wallBeam = (WallBeam)decorativeColumnObject;
                if (this.UbicationPoint.Equals(wallBeam.UbicationPoint))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }
    }
}
