using System.Drawing;

namespace Domain.Entities
{
    public class Wall : Element
    {
        public Point startUbicationPoint { get; set; }
        public Point endUbicationPoint { get; set; }
        private Pen wallPen;

        public Wall(Point startPoint, Point endPoint)
        {
            this.startUbicationPoint = startPoint;
            this.endUbicationPoint = endPoint;

            this.wallPen = new Pen(Color.LightGreen, 7);
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(this.wallPen, this.startUbicationPoint, this.endUbicationPoint);
        }

        public override bool Equals(object wallObject)
        {
            bool isEqual = false;
            if (wallObject != null && this.GetType().Equals(wallObject.GetType()))
            {
                Wall wall = (Wall)wallObject;
                if (this.startUbicationPoint.Equals(wall.startUbicationPoint) && (this.endUbicationPoint.Equals(wall.endUbicationPoint)))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }
        
        public bool SizeGreaterThanMaximum()
        {
            if(isHorizontalWall())
                return (this.startUbicationPoint.X - this.endUbicationPoint.X) > 5;
            else
                return (this.startUbicationPoint.Y - this.endUbicationPoint.Y) > 5;
        }

        public bool isHorizontalWall()
        {
            return this.startUbicationPoint.Y == this.endUbicationPoint.Y;
        }
        
        public Point CalculateLocationPoint(int maxMeters)
        {
            if (isHorizontalWall())
                return new Point(this.startUbicationPoint.Y + maxMeters);
            else
                return new Point(this.startUbicationPoint.X + maxMeters);
        }


    }
}
