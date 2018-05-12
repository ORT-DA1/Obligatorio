using Domain.Exceptions;
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

        public Wall(Point startPoint, Point endPoint)
        {

            this.FixWall();
            this.Validate();

            if (startPoint.Y.Equals(endPoint.Y)){
                if(startPoint.X < endPoint.Y)
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
                if (startPoint.Y > endPoint.Y)
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
            
            this.Path = new List<Point>();
            this.wallPen = new Pen(Color.LightGreen, 7);

            this.createPath();
        }

        public int getDistance()
        {
            if (isHorizontalWall())
                return this.startUbicationPoint.X - this.endUbicationPoint.X;
            else
                return this.startUbicationPoint.Y- this.endUbicationPoint.Y;
        }

        private void createPath()
        {
            if (isHorizontalWall())
            {
                for(int i=0;  i<getDistance();)
                {
                    Point point = new Point(this.startUbicationPoint.X + i,this.endUbicationPoint.Y);
                    this.Path.Add(point);
                    i+= Grid.PixelConvertor;
                } 
            }
            else
            {
                for (int i = 0; i < getDistance();)
                {
                    Point point = new Point(this.startUbicationPoint.X, this.endUbicationPoint.Y + i);
                    this.Path.Add(point);
                    i += Grid.PixelConvertor;
                }
            }
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

        public void Validate()
        {
            this.distintPoints();
            this.sameXorY();
        }

        private void sameXorY()
        {
            if (isHorizontalWall()) return;
            if (isVerticalWall()) return;
            else throw new ExceptionController(ExceptionMessage.INVALID_WALL);
        }

        private bool isVerticalWall()
        {
            return this.startUbicationPoint.X == this.endUbicationPoint.X;
        }

        private void distintPoints()
        {
            if(this.startUbicationPoint.Equals(this.endUbicationPoint))
                throw new ExceptionController(ExceptionMessage.INVALID_WALL);
        }

        public void FixWall()
        {
            Point startFixedWall = new Point(
                  ((int)Math.Round((double)this.startUbicationPoint.X / Grid.PixelConvertor)) * Grid.PixelConvertor,
                  ((int)Math.Round((double)this.startUbicationPoint.Y / Grid.PixelConvertor)) * Grid.PixelConvertor
              );

            Point endFixedWall = new Point(
                 ((int)Math.Round((double)this.endUbicationPoint.X / Grid.PixelConvertor)) * Grid.PixelConvertor,
                 ((int)Math.Round((double)this.endUbicationPoint.Y / Grid.PixelConvertor)) * Grid.PixelConvertor
              );

            this.startUbicationPoint = startFixedWall;
            this.endUbicationPoint = endFixedWall;
        }

        public bool SizeGreaterThanMaximum()
        {
            if(isHorizontalWall())
                return (this.endUbicationPoint.X - this.startUbicationPoint.X) > 5;
            else
                return (this.endUbicationPoint.Y - this.startUbicationPoint.Y) > 5;
        }

        public bool isHorizontalWall()
        {
            return this.startUbicationPoint.Y == this.endUbicationPoint.Y;
        }
        
        public Point CalculateLocationPoint(int maxMeters)
        {
            if (isHorizontalWall())
                return new Point(this.startUbicationPoint.X + maxMeters, this.endUbicationPoint.Y);
            else
                return new Point(this.startUbicationPoint.X ,this.startUbicationPoint.Y + maxMeters);
        }

        public Point FirstIntersection(Wall wall)
        {
            Point returnPoint;
            if (isHorizontalWall())
            {
                for (int i = 1; i < getDistance();)
                {
                    foreach (Point point in wall.Path)
                    {
                        if(point.X == this.startUbicationPoint.X + i)
                            return returnPoint = new Point(point.X, point.Y);
                    }
                    i += Grid.PixelConvertor;
                }
            }
            else
            {
                for (int i = 1; i < getDistance();)
                {
                    foreach (Point point in wall.Path)
                    {
                        if (point.Y == this.startUbicationPoint.Y + i)
                            return returnPoint = new Point(point.X, point.Y);
                    }
                    i += Grid.PixelConvertor;
                }
            }
            return returnPoint = new Point();
        }

    }
}
