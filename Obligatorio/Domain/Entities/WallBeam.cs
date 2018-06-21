using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Domain.Entities
{
    [Table(name: "WallBeams")]
    public class WallBeam : Element
    {
        #region PK and FK
        public int WallBeamId { get; set; }
        public virtual Grid Grid { get; set; }
        #endregion

        public Point UbicationPoint { get; set; }

        public SolidBrush wallBeamBrush = new SolidBrush(Color.Red);

        public static Tuple<int, int> CostPriceWallBeam = new Tuple<int, int>(50, 100);

        #region Constructors
        public WallBeam() { }
        public WallBeam(Point ubicationPoint)
        {
            this.UbicationPoint = ubicationPoint;
            this.wallBeamBrush = new SolidBrush(Color.Red);
        }
        #endregion

        public override void ModifyCostAndPrice(int Cost, int Price)
        {
            CostPriceWallBeam = new Tuple<int, int>(Cost, Price);
        }

        public override void Draw(Graphics graphic)
        {
            Rectangle rectangle = new Rectangle(this.UbicationPoint.X-5, this.UbicationPoint.Y-5, 10, 10);
            float startAngle = 0;
            float sweepAngle = 360;
            graphic.FillPie(wallBeamBrush, rectangle, startAngle, sweepAngle);
        }

        public override bool Equals(object wallBeamObject)
        {
            bool isEqual = false;
            if (wallBeamObject != null && this.GetType().Equals(wallBeamObject.GetType()))
            {
                WallBeam wallBeam = (WallBeam)wallBeamObject;
                if (this.UbicationPoint.Equals(wallBeam.UbicationPoint))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }
    }
}
