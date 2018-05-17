using Domain.Exceptions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;
using Domain.Logic;

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

        public Tuple<int, int> CostPriceMeterWall { get; set; }
        public Tuple<int, int> CostPriceWallBeam { get; set; }
        public Tuple<int, int> CostPriceWindow { get; set; }
        public Tuple<int, int> CostPriceDoor { get; set; }

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

            this.CostPriceMeterWall = new Tuple<int, int>(50, 100);
            this.CostPriceWallBeam = new Tuple<int, int>(50, 100);
            this.CostPriceWindow = new Tuple<int, int>(50, 75);
            this.CostPriceDoor = new Tuple<int, int>(50, 100);

            this.gridPen = new Pen(Color.Black, 2);
        }

        public void modifyCostAndPrice(Tuple<int, int> meterWall, Tuple<int, int> wallBeam, Tuple<int, int> window, Tuple<int, int> door)
        {
            this.CostPriceMeterWall = meterWall;
            this.CostPriceWallBeam = wallBeam;
            this.CostPriceWindow = window;
            this.CostPriceDoor = door;
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
            if (isCuttingAWallBeforeMaximum(wall))
            {
                Point intersection = this.FirstIntersection(wall);
                Wall intersectWall = this.FirstIntersectWall(wall);
                breakWall(intersectWall, intersection);
                Wall newWall = new Wall(wall.startUbicationPoint, intersection);
                AddWallBeam(graphic, newWall.startUbicationPoint);
                AddWallBeam(graphic, newWall.endUbicationPoint);
                newWall.Draw(graphic);
                this.Walls.Add(newWall);
                AddWallBeam(graphic, newWall.startUbicationPoint);
                AddWallBeam(graphic, newWall.endUbicationPoint);
                Wall anotherWall = new Wall(intersection, wall.endUbicationPoint);
                AddWall(graphic, anotherWall);
            }
            else if (wall.SizeGreaterThanMaximum())
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
            else
            {
                wall.Draw(graphic);
                this.Walls.Add(wall);
                AddWallBeam(graphic, wall.startUbicationPoint);
                AddWallBeam(graphic, wall.endUbicationPoint);
            }
        }

        public void breakWall(Wall intersectWall, Point intersection)
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
            foreach (Wall anotherWall in Walls)
            {
                foreach (Point anotherWallPathPoint in anotherWall.Path)
                {
                    foreach (Point point in wall.Path)
                    {
                        if (point.Equals(anotherWallPathPoint) && !point.Equals(wall.startUbicationPoint))
                        {
                            return anotherWall;
                        }
                    }
                }
            }
            return returnWall;
        }

        public Wall obtainWallInPoint(Point point)
        {
            Wall wall = this.Walls.First(anotherWall => anotherWall.Path.Contains(point));
            return wall;
        }

        public string wallSense(Point point)
        {
            Wall wall = this.Walls.First(anotherWall => anotherWall.Path.Contains(point));
            if (wall.isHorizontalWall()) return "horizontal";
            else return "vertical";
        }

        public bool isCuttingAWallBeforeMaximum(Wall wall)
        {
            foreach (Wall anotherWall in Walls)
            {
                if (isPerpendicular(wall, anotherWall))
                {
                    foreach (Point anotherPoint in anotherWall.Path)
                    {
                        foreach (Point point in wall.Path)
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
                        }
                    }
                }
            }
            return false;
        }

        public bool isPerpendicular(Wall wall, Wall anotherWall)
        {
            return ((wall.isHorizontalWall() && anotherWall.isVerticalWall())
                || wall.isVerticalWall() && anotherWall.isHorizontalWall());
        }

        public void IsValid(Wall wall)
        {
            if (!wall.startUbicationPoint.Equals(wall.endUbicationPoint))
            {
                this.HorizontalOrVertical(wall);
                this.AlreadyExistWall(wall);
                this.ContainedIn(wall);
            }
        }

        public void HorizontalOrVertical(Wall wall)
        {
            GridHandler.ValidWallOrientation(wall);
            /*if (wall.isHorizontalWall() || wall.isVerticalWall())
            {
            }
            else throw new ExceptionController(ExceptionMessage.WALL_ALREADY_EXSIST); // cambiar exception*/
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
                    throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_ABOVE);
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
                if (commonPoints > 1) return true;
                commonPoints = 0;
            }
            return commonPoints > 0;
        }

        public Point FirstIntersection(Wall wall)
        {
            Point returnPoint = new Point(-1, -1);
            foreach (Wall anotherWall in Walls)
            {
                foreach (Point anotherWallPathPoint in anotherWall.Path)
                {
                    foreach (Point point in wall.Path)
                    {
                        if (point.Equals(anotherWallPathPoint) && !point.Equals(wall.startUbicationPoint))
                        {
                            return point;
                        }
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
            };
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
            WallBeam startWallBeam = getWallBeam(wall.startUbicationPoint);
            WallBeam endWallBeam = getWallBeam(wall.endUbicationPoint);
            foreach (Point point in wall.Path)
            {
                if (existWindow(point))
                    this.Windows.Remove(this.Windows.First(windows => windows.StartPoint.Equals(point)));
                if (existDoor(point))
                    this.Doors.Remove(this.Doors.First(door => door.StartPoint.Equals(point)));
            }
            this.Walls.Remove(wall);
            RemoveWallBeam(startWallBeam);
            RemoveWallBeam(endWallBeam);
        }

        private bool existDoor(Point ubicationPoint)
        {
            return this.Doors.Contains(new Door(ubicationPoint, ubicationPoint, "vertical"));
        }

        private bool existWindow(Point ubicationPoint)
        {
            return this.Windows.Contains(new Window(ubicationPoint, ubicationPoint, "vertical"));
        }

        public WallBeam getWallBeam(Point startUbicationPoint)
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
            if (matchPoints == 0) throw new ExceptionController(ExceptionMessage.POINT_OUT_OF_WALL);
        }

        public void RemoveDoor(Point ubicationPoint)
        {
            if (existDoor(ubicationPoint))
            {
                Door door = this.Doors.First(anotherDoor => anotherDoor.StartPoint.Equals(ubicationPoint));
                this.Doors.Remove(door);
            }
        }

        public void RemoveWindow(Point ubicationPoint)
        {
            if (existWindow(ubicationPoint))
            {
                Window window = this.Windows.First(anotherWindow => anotherWindow.StartPoint.Equals(ubicationPoint));
                this.Windows.Remove(window);
            }
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
            return MetersWallCount() * CostPriceMeterWall.Item1;
        }

        public int AmountPriceWall()
        {
            return MetersWallCount() * CostPriceMeterWall.Item2;
        }

        public int AmountCostWallBeam()
        {
            return WallBeamsCount() * CostPriceWallBeam.Item1;
        }

        public int AmountPriceWallBeam()
        {
            return WallBeamsCount() * CostPriceWallBeam.Item2;
        }

        public int AmountCostWindow()
        {
            return WindowsCount() * CostPriceWindow.Item1;
        }

        public int AmountPriceWindow()
        {
            return WindowsCount() * CostPriceWindow.Item2;
        }

        public int AmountCostDoor()
        {
            return DoorsCount() * CostPriceDoor.Item1;
        }

        public int AmountPriceDoor()
        {
            return DoorsCount() * CostPriceDoor.Item2;
        }

        public int totalCost()
        {
            return AmountCostWall() + AmountCostWallBeam() + AmountCostWindow() + AmountPriceDoor();
        }

        public int totalPrice()
        {
            return AmountPriceWall() + AmountPriceWallBeam() + AmountPriceWindow() + AmountPriceDoor();
        }

        public Point fixPoint(Point point)
        {
            Point fixedPoint = new Point(
               ((int)Math.Round((double)point.X / PixelConvertor)) * PixelConvertor,
               ((int)Math.Round((double)point.Y / PixelConvertor)) * PixelConvertor
           );
            return fixedPoint;
        }

    }
}
