using System;
using System.Collections.Generic;
using System.Drawing;

namespace Domain.Entities
{
    public class Wall : Element
    {
        public Point startUbicationPoint { get; set; }
        public Point endUbicationPoint { get; set; }
        public List<Point> Path { get; set; }
        private Pen wallPen;

        public static Tuple<int, int> CostPriceMeterWall = new Tuple<int, int>(50, 100);

        public Wall(Point startPoint, Point endPoint)
        {
            SetRightSense(startPoint,endPoint);
            this.Path = new List<Point>();
            this.wallPen = new Pen(Color.LightGreen, 4);
            this.createPath();
        }

        public void SetRightSense(Point startPoint, Point endPoint)
        {
            if (startPoint.Y.Equals(endPoint.Y))
            {
                if (startPoint.X < endPoint.X)
                {
                    this.startUbicationPoint = startPoint;
                    this.endUbicationPoint = endPoint;
                }
                else
                {
                    this.startUbicationPoint = endPoint;
                    this.endUbicationPoint = startPoint;
                }
            }
            else
            {
                if (startPoint.Y < endPoint.Y)
                {
                    this.startUbicationPoint = startPoint;
                    this.endUbicationPoint = endPoint;
                }
                else
                {
                    this.startUbicationPoint = endPoint;
                    this.endUbicationPoint = startPoint;
                }
            }
        }

        public int getDistance()
        {
            if (isHorizontalWall())
                return Math.Abs((this.startUbicationPoint.X) - (this.endUbicationPoint.X));
            else
                return Math.Abs((this.startUbicationPoint.Y) - (this.endUbicationPoint.Y));
        }

        private void createPath()
        {
            int max = getDistance();
            if (isHorizontalWall())
            {
                for(int i=0;  i<= max;)
                {
                    Point point = new Point(this.startUbicationPoint.X + i,this.startUbicationPoint.Y);
                    this.Path.Add(point);
                    i+= Grid.PixelConvertor;
                } 
            }
            else
            {
                for (int i = 0; i <= max;)
                {
                    Point point = new Point(this.startUbicationPoint.X, this.startUbicationPoint.Y + i);
                    this.Path.Add(point);
                    i += Grid.PixelConvertor;
                }
            }
        }

        public override void ModifyCostAndPrice(int Cost, int Price)
        {
            CostPriceMeterWall = new Tuple<int, int>(Cost, Price);
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(this.wallPen, this.startUbicationPoint,    this.endUbicationPoint);
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
                return Math.Abs(this.endUbicationPoint.X /Grid.PixelConvertor - this.startUbicationPoint.X / Grid.PixelConvertor) > (5);
            else
                return Math.Abs(this.endUbicationPoint.Y / Grid.PixelConvertor - this.startUbicationPoint.Y / Grid.PixelConvertor) > (5);
        }

        public bool isHorizontalWall()
        {
            return this.startUbicationPoint.Y == this.endUbicationPoint.Y;
        }
        
        public Point CalculateLocationPoint(int maxMeters)
        {
            if (isHorizontalWall())
                return new Point(this.startUbicationPoint.X + (maxMeters * Grid.PixelConvertor), this.endUbicationPoint.Y);
            else
                return new Point(this.startUbicationPoint.X ,this.startUbicationPoint.Y + (maxMeters*Grid.PixelConvertor));
        }

        public bool isVerticalWall()
        {
            return this.startUbicationPoint.X == this.endUbicationPoint.X;
        }
    }
}
