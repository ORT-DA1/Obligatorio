using Domain.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Domain.Entities
{
    [Table(name: "Walls")]
    public class Wall : Element
    {
        #region PK and FK
        public int WallId { get; set; }
        public virtual Grid Grid { get; set; }
        public virtual PriceAndCost PriceAndCost { get; set; }
        #endregion

        public virtual Point startUbicationPoint { get; set; }
        public virtual Point endUbicationPoint { get; set; }
        public virtual List<Domain.Entities.Point> Path { get; set; }

        private Pen wallPen = new Pen(Color.LightGreen, 4);
        public PriceAndCostHandler priceAndCostHandler;


        #region Constructors
        public Wall()
        {

            this.Path = new List<Point>();
            this.wallPen = new Pen(Color.LightGreen, 4);
        }

        public Wall(Point startPoint, Point endPoint)
        {
            this.priceAndCostHandler = new PriceAndCostHandler();
            SetRightSense(startPoint, endPoint);
            this.Path = new List<Point>();
            this.wallPen = new Pen(Color.LightGreen, 4);
            this.createPath();
        }

        #endregion

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
                for (int i = 0; i <= max;)
                {
                    Point point = new Point(this.startUbicationPoint.X + i, this.startUbicationPoint.Y);
                    this.Path.Add(point);
                    i += Grid.PixelConvertor;
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

        public override void ModifyCostAndPrice(int cost, int price)
        {
            priceAndCostHandler.WallModifyPriceCost(cost, price);
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(this.wallPen, new System.Drawing.Point(this.startUbicationPoint.X, this.startUbicationPoint.Y)
                , new System.Drawing.Point(this.endUbicationPoint.X, this.endUbicationPoint.Y));
        }

        public override bool Equals(object wallObject)
        {
            bool isEqual = false;
            if (wallObject != null && this.GetType().Equals(wallObject.GetType()))
            {
                Wall wall = (Wall)wallObject;
                if (wall.startUbicationPoint != null && wall.endUbicationPoint != null)
                {
                    if (this.startUbicationPoint.Equals(wall.startUbicationPoint) && (this.endUbicationPoint.Equals(wall.endUbicationPoint)))
                    {
                        isEqual = true;
                    }
                }
            }
            return isEqual;
        }

        public bool SizeGreaterThanMaximum()
        {
            if (isHorizontalWall())
                return Math.Abs(this.endUbicationPoint.X / Grid.PixelConvertor - this.startUbicationPoint.X / Grid.PixelConvertor) > (5);
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
                return new Point(this.startUbicationPoint.X, this.startUbicationPoint.Y + (maxMeters * Grid.PixelConvertor));
        }

        public bool isVerticalWall()
        {
            return this.startUbicationPoint.X == this.endUbicationPoint.X;
        }
    }
}
