﻿using Domain.Exceptions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Logic;
using Domain.Repositories;

namespace Domain.Entities
{
    [Table(name: "Grids")]
    public class Grid
    {
        public int GridId { get; set; }
        public GridStrategy GridStrategy { get; set; }
        public string GridName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        
        public GridRepository gridRepository;
        
        #region navigation
        public virtual Client Client { get; set; }
        public virtual List<Wall> Walls { get; set; }
        public virtual List<WallBeam> WallBeams { get; set; }
        public virtual List<DecorativeColumn> DecorativeColumns { get; set; }
        public virtual List<Window> Windows { get; set; }
        public virtual List<Door> Doors { get; set; }
        #endregion

        public static int PixelConvertor = 25;
        public int MaxMeters = 5;

        public GridHandler GRID_HANDLER;
        public WallHandler WALL_HANDLER;
        public DoorHandler DOOR_HANDLER;
        public WallBeamHandler WALLBEAM_HANDLER;
        public WindowHandler WINDOW_HANDLER;
        public DecorativeColumnHandler DECORATIVECOLUMN_HANDLER;

        public Grid()
        {
            this.gridRepository = new GridRepository();
        }

        public Grid(string gridName, Client client, int height, int width)
        {
            this.gridRepository = new GridRepository();
            this.Walls = new List<Wall>();
            this.WallBeams = new List<WallBeam>();
            this.DecorativeColumns = new List<DecorativeColumn>();
            this.Windows = new List<Window>();
            this.Doors = new List<Door>();

            this.GridName = gridName;
            this.Client = client;
            this.Height = height * PixelConvertor;
            this.Width = width * PixelConvertor;
            this.GRID_HANDLER = new GridHandler();
            this.WALLBEAM_HANDLER = new WallBeamHandler(gridRepository);
            this.WALL_HANDLER = new WallHandler(gridRepository);
            this.WINDOW_HANDLER = new WindowHandler(gridRepository);
            this.DECORATIVECOLUMN_HANDLER = new DecorativeColumnHandler(gridRepository);
            this.DOOR_HANDLER = new DoorHandler(gridRepository);
        }

        public void DrawWalls(Graphics graphic)
        {
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            { 
                wall.Draw(graphic);
            }
        }

        public void DrawDoors(Graphics graphic)
        {
            foreach (Door door in DOOR_HANDLER.GetList(this))
            {
                door.Draw(graphic);
            }
        }

        public void DrawWallBeams(Graphics graphic)
        {
            foreach (WallBeam wallBeam in WallBeams)
            {
                wallBeam.Draw(graphic);
            }
        }

        public void DrawDecorativeColumns(Graphics graphic)
        {
            foreach (DecorativeColumn decorativeColumn in DECORATIVECOLUMN_HANDLER.GetList(this))
            {
                decorativeColumn.Draw(graphic);
            }
        }

        public void DrawWindows(Graphics graphic)
        {
            foreach (Window window in WINDOW_HANDLER.GetList(this))
            {
                window.Draw(graphic);
            }
        }

        public void AddWall(Graphics graphic, Wall wall)
        {
            if (IsCuttingAWallBeforeMaximum(wall))
            {
                AddWallIfCutting(graphic, wall);
            }
            else if (wall.SizeGreaterThanMaximum())
            {
                AddWallIfSizeGreaterThanMaximum(graphic, wall);
            }
            else
            {
                AddWallNormal(graphic, wall);
            }
        }

        private void AddWallNormal(Graphics graphic, Wall wall)
        {
            wall.Draw(graphic);
            WALL_HANDLER.Add(this, wall);
            AddWallBeam(graphic, wall.startUbicationPoint);
            AddWallBeam(graphic, wall.endUbicationPoint);
        }

        private void AddWallIfSizeGreaterThanMaximum(Graphics graphic, Wall wall)
        {
            Point calculatedPoint = wall.CalculateLocationPoint(MaxMeters);
            Wall anotherWall = new Wall(wall.startUbicationPoint, calculatedPoint);
            AddWallBeam(graphic, anotherWall.startUbicationPoint);
            AddWallBeam(graphic, anotherWall.endUbicationPoint);
            WALL_HANDLER.Add(this, anotherWall);
            anotherWall.Draw(graphic);
            Wall newWall = new Wall(calculatedPoint, wall.endUbicationPoint);
            AddWall(graphic, newWall);
        }

        private void AddWallIfCutting(Graphics graphic, Wall wall)
        {
            Point intersection = this.FirstIntersection(wall);
            Wall intersectWall = this.FirstIntersectWall(wall);
            AddWallBeam(graphic, intersectWall.startUbicationPoint);
            AddWallBeam(graphic, intersectWall.endUbicationPoint);
            BreakWall(intersectWall, intersection);
            Wall newWall = new Wall(wall.startUbicationPoint, intersection);
            AddWallBeam(graphic, newWall.startUbicationPoint);
            AddWallBeam(graphic, newWall.endUbicationPoint);
            newWall.Draw(graphic);
            WALL_HANDLER.Add(this, newWall);
            Wall anotherWall = new Wall(intersection, wall.endUbicationPoint);
            AddWall(graphic, anotherWall);
        }

        public void BreakWall(Wall intersectWall, Point intersection)
        {
            Wall newWall = new Wall(intersectWall.startUbicationPoint, intersection);
            Wall anotherNewWall = new Wall(intersection, intersectWall.endUbicationPoint);
            //WALL_HANDLER.Remove(this, intersectWall);
            WALL_HANDLER.Add(this, newWall);
            WALL_HANDLER.Add(this, anotherNewWall);
        }
        
        private Wall FirstIntersectWall(Wall wall)
        {
            Wall returnWall = new Wall(new Point(-1, -1), new Point(-1, -1));
            foreach (Point point in wall.Path)
            {
                foreach (Wall anotherWall in WALL_HANDLER.GetList(this))
                {
                    foreach (Point anotherPoint in anotherWall.Path)
                    {
                        if (EqualPointButNotAtStart(point, anotherPoint, wall))
                            return anotherWall;
                    }
                }
            }
            return returnWall;
        }

        private bool EqualPointButNotAtStart(Point point, Point anotherWallPathPoint, Wall wall)
        {
            if (point.Equals(anotherWallPathPoint) && !point.Equals(wall.startUbicationPoint))
                return true;
            else
                return false;
        }

        public Wall ObtainWallInPoint(Point point)
        {
            if (ThereIsAWallAtThisPoint(point))
            {
                return WALL_HANDLER.ObtainWallInPoint(this, point);
            }
            else throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        private bool ThereIsAWallAtThisPoint(Point point)
        {
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                foreach (Point anotherPoint in wall.Path)
                {
                    if (point.Equals(anotherPoint))
                        return true;
                }
            }
            return false;
        }

        public string WallSense(Point point)
        {
            if (ThereIsAWallAtThisPoint(point))
            {
                Wall wall = WALL_HANDLER.GetList(this).First(anotherWall => anotherWall.Path.Contains(point));
                if (wall.isHorizontalWall())
                    return "horizontal";
                else
                    return "vertical";
            }
            else throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        public bool IsCuttingAWallBeforeMaximum(Wall wall)
        {
            foreach (Wall anotherWall in WALL_HANDLER.GetList(this))
            {
                if (IsPerpendicular(wall, anotherWall))
                {
                    foreach (Point anotherPoint in WALL_HANDLER.GetWallPath(anotherWall))
                    {
                        foreach (Point point in WALL_HANDLER.GetWallPath(wall))
                        {
                            if (VerifyCuttingDistance(wall, point, anotherPoint))
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool VerifyCuttingDistance(Wall wall, Point point, Point anotherPoint)
        {
            if (wall.isHorizontalWall())
            {
                if (point.Equals(anotherPoint) && !point.Equals(wall.startUbicationPoint)
                    && !point.Equals(wall.Path.Last())
                && (anotherPoint.X - wall.startUbicationPoint.X) < 125)
                    return true;
            }
            else
            {
                if (point.Equals(anotherPoint) && !point.Equals(wall.startUbicationPoint)
                    && !point.Equals(wall.Path.Last())
                    && (anotherPoint.Y - wall.startUbicationPoint.Y) < 125)
                    return true;
            }
            return false;
        }

        public bool IsPerpendicular(Wall wall, Wall anotherWall)
        {
            return ((wall.isHorizontalWall() && anotherWall.isVerticalWall())
                || wall.isVerticalWall() && anotherWall.isHorizontalWall());
        }
        
        public Point FirstIntersection(Wall wall)
        {
            Point returnPoint = new Point(-1, -1);
            foreach (Point point in wall.Path)
            {
                foreach (Wall anotherWall in WALL_HANDLER.GetList(this))
                {
                    foreach (Point anotherPoint in anotherWall.Path)
                    {
                        if (EqualPointButNotAtStart(point, anotherPoint, wall))
                            return point;
                    }
                }
            }
            return returnPoint;
        }

        public void AddWallBeam(Graphics graphic, Point ubicationPoint)
        {
            if (FreePosition(ubicationPoint))
            {
                WallBeam wallBeam = new WallBeam(ubicationPoint);
                WALLBEAM_HANDLER.Add(this, wallBeam);
                wallBeam.Draw(graphic);
            }
        }

        public void AddDecorativeColumn(Graphics graphic, Point ubicationPoint)
        {
            if (FreePosition(ubicationPoint))
            {
                if (noWallInPosition(ubicationPoint))
                {
                    DecorativeColumn decorativeColumn = new DecorativeColumn(ubicationPoint);
                    DECORATIVECOLUMN_HANDLER.Add(this, decorativeColumn);
                    decorativeColumn.Draw(graphic);
                }
            }
        }

        private bool noWallInPosition(Point ubicationPoint)
        {
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                foreach (Point point in wall.Path)
                {
                    if (point.Equals(ubicationPoint))
                        return false;
                }
            }
            return true;
        }

        public bool FreePosition(Point ubicationPoint)
        {
            List<Window> windowList = WINDOW_HANDLER.GetList(this).Where(window => window.StartPoint.Equals(ubicationPoint)).ToList();
            List<Door> doorList = DOOR_HANDLER.GetList(this).Where(door => door.StartPoint.Equals(ubicationPoint)).ToList();
            return (!this.WALLBEAM_HANDLER.GetList(this).Contains(new WallBeam(ubicationPoint))
                && windowList.Count == 0
                && doorList.Count == 0);
        }

        public void RemoveWall(Wall wall)
        {
            WallBeam startWallBeam = GetWallBeam(wall.startUbicationPoint);
            WallBeam endWallBeam = GetWallBeam(wall.endUbicationPoint);
            DeleteElementsInAWall(wall);
            WALL_HANDLER.Remove(this, wall);
            RemoveWallBeam(startWallBeam);
            RemoveWallBeam(endWallBeam);
        }

        private void DeleteElementsInAWall(Wall wall)
        {
            foreach (Point point in wall.Path)
            {
                if (ExistWindow(point))
                    WINDOW_HANDLER.Remove(this, (WINDOW_HANDLER.GetList(this).First(windows => windows.StartPoint.Equals(point))));
                if (ExistDoor(point))
                    DOOR_HANDLER.Remove(this, (DOOR_HANDLER.GetList(this).First(door => door.StartPoint.Equals(point))));
            }
        }

        private bool ExistDoor(Point ubicationPoint)
        {
            return DOOR_HANDLER.Exist(this, (new Door(ubicationPoint, ubicationPoint, "vertical")));
        }

        private bool ExistWindow(Point ubicationPoint)
        {
            return WINDOW_HANDLER.Exist(this, (new Window(ubicationPoint, ubicationPoint, "vertical")));
        }

        public WallBeam GetWallBeam(Point startUbicationPoint)
        {
            return WALLBEAM_HANDLER.GetWallBeam(this, startUbicationPoint);
        }

        public void RemoveWallBeam(WallBeam wallBeam)
        {
            List<Wall> useAWallBeam = new List<Wall>();
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                if (ContainsPoint(wall.Path, wallBeam.UbicationPoint))
                {
                    useAWallBeam.Add(wall);
                }
            }
            if (useAWallBeam.Count.Equals(0))
            {
                WALLBEAM_HANDLER.Remove(this, wallBeam);
            }
        }

        public bool ContainsPoint(List<Point> list, Point point)
        {
            foreach (Point anotherPoint in list)
            {
                if (anotherPoint.Equals(point))
                    return true;
            }
            return false;
        }

        public void AddWindow(Graphics graphic, Point startPoint, Point endPoint, string sense)
        {
            if (FreePosition(startPoint))
            {
                Window window = new Window(startPoint, endPoint, sense);
                this.Windows.Add(new Window(startPoint, endPoint, sense));
                window.Draw(graphic);
            }
        }

        public void RemoveDecorativeColumn(Point ubicationPoint)
        {
            if (ExistDecorativeColumn(ubicationPoint))
            {
                DecorativeColumn decorativeColumn = this.DecorativeColumns.First(anotherDecorativeColumn => anotherDecorativeColumn.UbicationPoint.Equals(ubicationPoint));
                DECORATIVECOLUMN_HANDLER.Remove(this, decorativeColumn);
            }
        }

        private bool ExistDecorativeColumn(Point ubicationPoint)
        {
            return DECORATIVECOLUMN_HANDLER.Exist(this, new DecorativeColumn(ubicationPoint));
        }

        public void RemoveWindow(Window window)
        {
            WINDOW_HANDLER.Remove(this, window);
        }

        public void AddDoor(Graphics graphic, Point startPoint, Point endPoint, string sense)
        {
            OnTheWall(startPoint);
            if (FreePosition(startPoint))
            {
                Door door = new Door(startPoint, endPoint, sense);
                DOOR_HANDLER.Add(this, new Door(startPoint, endPoint, sense));
                door.Draw(graphic);
            }
        }

        public void OnTheWall(Point ubicationPoint)
        {
            int matchPoints = 0;
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                foreach (Point point in wall.Path)
                {
                    if (point.Equals(ubicationPoint))
                        matchPoints++;
                }
            }
            if (matchPoints == 0)
                throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        public void RemoveDoor(Point ubicationPoint)
        {
            if (ExistDoor(ubicationPoint))
            {
                Door door = DOOR_HANDLER.GetList(this).First(anotherDoor => anotherDoor.StartPoint.Equals(ubicationPoint));
                DOOR_HANDLER.Remove(this, door);
            }
            else throw new ExceptionController(ExceptionMessage.DOOR_NOT_EXIST);
        }

        public void RemoveWindow(Point ubicationPoint)
        {
            if (ExistWindow(ubicationPoint))
            {
                Window window = WINDOW_HANDLER.GetList(this).First(anotherWindow => anotherWindow.StartPoint.Equals(ubicationPoint));
                WINDOW_HANDLER.Remove(this, window);
            }
            else throw new ExceptionController(ExceptionMessage.WINDOW_NOT_EXIST);
        }

        public override bool Equals(object gridObject)
        {
            bool isEqual = false;
            if (gridObject != null && this.GetType().Equals(gridObject.GetType()))
            {
                Grid grid = (Grid)gridObject;
                if ((this.Client.Equals(grid.Client)))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }

        public int MetersWallCount()
        {
            int amountMeters = 0;
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                foreach (Point point in wall.Path)
                {
                    amountMeters++;
                }
                amountMeters -= 1;
            }
            return amountMeters;
        }

        public int WallBeamsCount()
        {
            return WALLBEAM_HANDLER.Count(this);
        }

        public int WindowsCount()
        {
            return WINDOW_HANDLER.Count(this);
        }

        public int DoorsCount()
        {
            return DOOR_HANDLER.Count(this);
        }

        public int AmountCostWall()
        {
            int result = 0;
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                result += MetersWallCount() * Wall.CostPriceMeterWall.Item1;
            }
            return result;
        }

        public int AmountPriceWall()
        {
            int result = 0;
            foreach (Wall wall in WALL_HANDLER.GetList(this))
            {
                result += MetersWallCount() * Wall.CostPriceMeterWall.Item2;
            }
            return result;
        }

        public int AmountCostWallBeam()
        {
            int result = 0;
            foreach (WallBeam wallBeam in WALLBEAM_HANDLER.GetList(this))
            {
                result += WallBeamsCount() * WallBeam.CostPriceWallBeam.Item1;
            }
            return result;
        }

        public int AmountPriceWallBeam()
        {
            int result = 0;
            foreach (WallBeam wallBeam in WALLBEAM_HANDLER.GetList(this))
            {
                result += WallBeamsCount() * WallBeam.CostPriceWallBeam.Item2;
            }
            return result;
        }

        public int AmountCostWindow()
        {
            int result = 0;
            foreach (Window window in WINDOW_HANDLER.GetList(this))
            {
                result += WindowsCount() * Window.CostPriceWindow.Item1;
            }
            return result;
        }

        public int AmountPriceWindow()
        {
            int result = 0;
            foreach (Window window in WINDOW_HANDLER.GetList(this))
            {
                result += WindowsCount() * Window.CostPriceWindow.Item2;
            }
            return result;
        }

        public int AmountCostDoor()
        {
            int result = 0;
            foreach (Door door in DOOR_HANDLER.GetList(this))
            {
                result += DoorsCount() * Door.CostPriceDoor.Item1;
            }
            return result;
        }

        public int AmountPriceDoor()
        {
            int result = 0;
            foreach (Door door in DOOR_HANDLER.GetList(this))
            {
                result += DoorsCount() * Door.CostPriceDoor.Item2;
            }
            return result;
        }

        public int TotalCost()
        {
            return AmountCostWall() + AmountCostWallBeam() + AmountCostWindow() + AmountCostDoor();
        }

        public int TotalPrice()
        {
            return AmountPriceWall() + AmountPriceWallBeam() + AmountPriceWindow() + AmountPriceDoor();
        }

        public override string ToString()
        {
            string format = "{0} - {1}";
            return String.Format(format, this.GridName, this.Client.Username);
        }

        public System.Drawing.Point FixPoint(System.Drawing.Point point)
        {
            System.Drawing.Point fixedPoint = new System.Drawing.Point(
               ((int)Math.Round((double)point.X / PixelConvertor)) * PixelConvertor,
               ((int)Math.Round((double)point.Y / PixelConvertor)) * PixelConvertor
           );
            return fixedPoint;
        }

    }
}
