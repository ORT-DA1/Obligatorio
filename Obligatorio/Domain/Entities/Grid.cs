using Domain.Exceptions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;

namespace Domain.Entities
{
    public class Grid
    {
        public string GridName { get; set; }
        public Client Client { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Wall> Walls { get; set; }
        public List<WallBeam> WallBeams { get; set; }
        public List<Window> Windows { get; set; }
        public List<Door> Doors { get; set; }
        public static int PixelConvertor = 25;
        public int MaxMeters = 5;
        private Pen gridPen;
       
        public Grid() { }

        public Grid(string gridName, Client client, int height, int width)
        {
            this.Walls = new List<Wall>();
            this.WallBeams = new List<WallBeam>();
            this.Windows = new List<Window>();
            this.Doors = new List<Door>();

            this.GridName = gridName;
            this.Client = client;
            this.Height = height * PixelConvertor;
            this.Width = width * PixelConvertor;

            this.gridPen = new Pen(Color.Black, 2);
        }

        public void DrawGrid(Graphics graphic)
        {
            this.DrawX(graphic);
            this.DrawY(graphic);
        }

        public void DrawWalls(Graphics graphic)
        {
            foreach (Wall wall in Walls)
            {
                wall.Draw(graphic);
            }
        }

        public void DrawDoors(Graphics graphic)
        {
            foreach (Door door in Doors)
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

        public void DrawWindows(Graphics graphic)
        {
            foreach (Window window in Windows)
            {
                window.Draw(graphic);
            }
        }

        private void DrawX(Graphics graphic)
        {
            for (int i = PixelConvertor; i < this.Height; i += PixelConvertor)
            {
                Point startPoint = new Point(0, i);
                Point endPoint = new Point(this.Width, i);
                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }

        private void DrawY(Graphics graphic)
        {
            for (int i = PixelConvertor; i < this.Width; i += PixelConvertor)
            {
                Point startPoint = new Point(i, 0);
                Point endPoint = new Point(i, this.Height);
                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }

        public void AddWall(Graphics graphic, Wall wall)
        {
            this.IsValid(wall);
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
            this.Walls.Add(wall);
            AddWallBeam(graphic, wall.startUbicationPoint);
            AddWallBeam(graphic, wall.endUbicationPoint);
        }

        private void AddWallIfSizeGreaterThanMaximum(Graphics graphic, Wall wall)
        {
            Point calculatedPoint = wall.CalculateLocationPoint(MaxMeters);
            Wall anotherWall = new Wall(wall.startUbicationPoint, calculatedPoint);
            AddWallBeam(graphic, anotherWall.startUbicationPoint);
            AddWallBeam(graphic, anotherWall.endUbicationPoint);
            this.Walls.Add(anotherWall);
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
            this.Walls.Add(newWall);
            Wall anotherWall = new Wall(intersection, wall.endUbicationPoint);
            AddWall(graphic, anotherWall);
        }

        public void BreakWall(Wall intersectWall, Point intersection)
        {
            Wall newWall = new Wall(intersectWall.startUbicationPoint, intersection);
            Wall anotherNewWall = new Wall(intersection, intersectWall.endUbicationPoint);
            this.Walls.Remove(intersectWall);
            this.Walls.Add(newWall);
            this.Walls.Add(anotherNewWall);
        }

        private Wall FirstIntersectWall(Wall wall)
        {
            Wall returnWall = new Wall(new Point(-1, -1), new Point(-1, -1));
            foreach (Point point in wall.Path)
            {
                foreach (Wall anotherWall in Walls)
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
                Wall wall = this.Walls.First(anotherWall => anotherWall.Path.Contains(point));
                return wall;
            }
            else throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        private bool ThereIsAWallAtThisPoint(Point point)
        {
            foreach (Wall wall in Walls)
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
                Wall wall = this.Walls.First(anotherWall => anotherWall.Path.Contains(point));
                if (wall.isHorizontalWall())
                    return "horizontal";
                else
                    return "vertical";
            }
            else throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        public bool IsCuttingAWallBeforeMaximum(Wall wall)
        {
            foreach (Wall anotherWall in Walls)
            {
                if (IsPerpendicular(wall, anotherWall))
                {
                    foreach (Point anotherPoint in anotherWall.Path)
                    {
                        foreach (Point point in wall.Path)
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
                && (anotherPoint.X - wall.startUbicationPoint.X) < 125)
                    return true;
            }
            else
            {
                if (point.Equals(anotherPoint) && !point.Equals(wall.startUbicationPoint)
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

        public void IsValid(Wall wall)
        {
            this.StartPointAndEndPointAreDifferent(wall);
            this.HorizontalOrVertical(wall);
            this.AlreadyExistWall(wall);
            this.ContainedIn(wall);
        }

        private void StartPointAndEndPointAreDifferent(Wall wall)
        {
            if (wall.startUbicationPoint.Equals(wall.endUbicationPoint))
            {
                throw new ExceptionController(ExceptionMessage.WALL_INVALID);
            }
        }

        public void HorizontalOrVertical(Wall wall)
        {
            if (!wall.isHorizontalWall() && !wall.isVerticalWall())
            {
                throw new ExceptionController(ExceptionMessage.WALL_INVALID);
            }
        }

        public void AlreadyExistWall(Wall wall)
        {
            if (this.Walls.Contains(wall))
            {
                throw new ExceptionController(ExceptionMessage.WALL_ALREADY_EXSIST);
            }
        }

        private void ContainedIn(Wall wall)
        {
            foreach (Wall anotherWall in Walls)
            {
                if (HasTwoPointsInCommon(wall, anotherWall))
                {
                    throw new ExceptionController(ExceptionMessage.WALL_INVALID);
                }
            }
        }

        public bool HasTwoPointsInCommon(Wall wall, Wall anotherWall)
        {
            int commonPoints = 0;
            foreach (Point point in wall.Path)
            {
                foreach (Point anotherPoint in anotherWall.Path)
                {
                    if (point.Equals(anotherPoint))
                        commonPoints++;
                }
                if (commonPoints > 1)
                    return true;
            }
            return commonPoints > 1;
        }

        public Point FirstIntersection(Wall wall)
        {
            Point returnPoint = new Point(-1, -1);
            foreach (Point point in wall.Path)
            {
                foreach (Wall anotherWall in Walls)
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
                this.WallBeams.Add(wallBeam);
                wallBeam.Draw(graphic);
            }
        }

        public bool FreePosition(Point ubicationPoint)
        {
            List<Window> windowList = this.Windows.Where(window => window.StartPoint.Equals(ubicationPoint)).ToList();
            List<Door> doorList = this.Doors.Where(door => door.StartPoint.Equals(ubicationPoint)).ToList();
            return (!this.WallBeams.Contains(new WallBeam(ubicationPoint))
                && windowList.Count == 0
                && doorList.Count == 0);
        }

        public void RemoveWall(Wall wall)
        {
            WallBeam startWallBeam = GetWallBeam(wall.startUbicationPoint);
            WallBeam endWallBeam = GetWallBeam(wall.endUbicationPoint);
            DeleteElementsInAWall(wall);
            this.Walls.Remove(wall);
            RemoveWallBeam(startWallBeam);
            RemoveWallBeam(endWallBeam);
        }

        private void DeleteElementsInAWall(Wall wall)
        {
            foreach (Point point in wall.Path)
            {
                if (ExistWindow(point))
                    this.Windows.Remove(this.Windows.First(windows => windows.StartPoint.Equals(point)));
                if (ExistDoor(point))
                    this.Doors.Remove(this.Doors.First(door => door.StartPoint.Equals(point)));
            }
        }

        private bool ExistDoor(Point ubicationPoint)
        {
            return this.Doors.Contains(new Door(ubicationPoint, ubicationPoint, "vertical"));
        }

        private bool ExistWindow(Point ubicationPoint)
        {
            return this.Windows.Contains(new Window(ubicationPoint, ubicationPoint, "vertical"));
        }

        public WallBeam GetWallBeam(Point startUbicationPoint)
        {
            return WallBeams.First(wallBeam => wallBeam.UbicationPoint.Equals(startUbicationPoint));
        }

        public void RemoveWallBeam(WallBeam wallBeam)
        {
            List<Wall> useAWallBeam = new List<Wall>();
            foreach (Wall wall in this.Walls)
            {
                if (ContainsPoint(wall.Path, wallBeam.UbicationPoint))
                {
                    useAWallBeam.Add(wall);
                }
            }
            if (useAWallBeam.Count.Equals(0))
            {
                this.WallBeams.Remove(wallBeam);
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

        public void RemoveWindow(Window window)
        {
            this.Windows.Remove(window);
        }

        public void AddDoor(Graphics graphic, Point startPoint, Point endPoint, string sense)
        {
            OnTheWall(startPoint);
            if (FreePosition(startPoint))
            {
                Door door = new Door(startPoint, endPoint, sense);
                this.Doors.Add(new Door(startPoint, endPoint, sense));
                door.Draw(graphic);
            }
        }

        public void OnTheWall(Point ubicationPoint)
        {
            int matchPoints = 0;
            foreach (Wall wall in Walls)
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
                Door door = this.Doors.First(anotherDoor => anotherDoor.StartPoint.Equals(ubicationPoint));
                this.Doors.Remove(door);
            }
            else throw new ExceptionController(ExceptionMessage.DOOR_NOT_EXIST);
        }

        public void RemoveWindow(Point ubicationPoint)
        {
            if (ExistWindow(ubicationPoint))
            {
                Window window = this.Windows.First(anotherWindow => anotherWindow.StartPoint.Equals(ubicationPoint));
                this.Windows.Remove(window);
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
            foreach (Wall wall in Walls)
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
            return this.WallBeams.Count();
        }

        public int WindowsCount()
        {
            return this.Windows.Count();
        }

        public int DoorsCount()
        {
            return this.Doors.Count();
        }

        public int AmountCostWall()
        {
            int result = 0;
            foreach(Wall wall in Walls)
            {
                result += MetersWallCount() * wall.CostPriceMeterWall.Item1;
            }
            return result;
        }

        public int AmountPriceWall()
        {
            int result = 0;
            foreach (Wall wall in Walls)
            {
                result += MetersWallCount() * wall.CostPriceMeterWall.Item2;
            }
            return result;
        }

        public int AmountCostWallBeam()
        {
            int result = 0;
            foreach (WallBeam wallBeam in WallBeams)
            {
                result += WallBeamsCount() * wallBeam.CostPriceWallBeam.Item1;
            }
            return result;
        }

        public int AmountPriceWallBeam()
        {
            int result = 0;
            foreach (WallBeam wallBeam in WallBeams)
            {
                result += WallBeamsCount() * wallBeam.CostPriceWallBeam.Item2;
            }
            return result;
        }

        public int AmountCostWindow()
        {
            int result = 0;
            foreach (Window window in Windows)
            {
                result += WindowsCount() * window.CostPriceWindow.Item1;
            }
            return result;
        }

        public int AmountPriceWindow()
        {
            int result = 0;
            foreach (Window window in Windows)
            {
                result += WindowsCount() * window.CostPriceWindow.Item2;
            }
            return result;
        }

        public int AmountCostDoor()
        {
            int result = 0;
            foreach (Door door in Doors)
            {
                result += DoorsCount() * door.CostPriceDoor.Item1;
            }
            return result;
        }

        public int AmountPriceDoor()
        {
            int result = 0;
            foreach (Door door in Doors)
            {
                result += DoorsCount() * door.CostPriceDoor.Item2;
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

        public Point FixPoint(Point point)
        {
            Point fixedPoint = new Point(
               ((int)Math.Round((double)point.X / PixelConvertor)) * PixelConvertor,
               ((int)Math.Round((double)point.Y / PixelConvertor)) * PixelConvertor
           );
            return fixedPoint;
        }

    }
}
