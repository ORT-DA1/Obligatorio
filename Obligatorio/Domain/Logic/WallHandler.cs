using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;
using Domain.Exceptions;
using Domain.Repositories;

namespace Domain.Logic
{
    public class WallHandler : IElementHandler<Wall>
    {
        private GridHandler gridHandler;
        private IWallRepository wallRepository;
        private DecorativeColumnHandler DECORATIVECOLUMN_HANDLER;

        public WallHandler()
        {
            this.gridHandler = new GridHandler();
            this.wallRepository = new WallRepository();
            this.DECORATIVECOLUMN_HANDLER = new DecorativeColumnHandler();
        }


        public void Add(Grid grid, Wall wall)
        {
            try { 
            wall.Grid = gridHandler.Get(grid);
            this.wallRepository.Add(grid, wall);
            }catch(Exception e) { 
            
            }
        }

        public void IsValid(Grid grid, Wall wall)
        {
            this.NoDecorativeColumnInterrupting(grid, wall);
            this.StartPointAndEndPointAreDifferent(wall);
            this.HorizontalOrVertical(wall);
            this.AlreadyExistWall(grid, wall);
            this.ContainedIn(grid, wall);
        }

        private void NoDecorativeColumnInterrupting(Grid grid, Wall wall)
        {
            foreach (Point point in wall.Path)
            {
                foreach (DecorativeColumn decorativeColumn in DECORATIVECOLUMN_HANDLER.GetList(grid))
                {
                    if (decorativeColumn.UbicationPoint.X.Equals(point.X) && decorativeColumn.UbicationPoint.Y.Equals(point.Y))
                        throw new ExceptionController(ExceptionMessage.WALL_INVALID);
                }
            }
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

        public void AlreadyExistWall(Grid grid, Wall wall)
        {
            if (this.GetList(grid).Contains(wall))
            {
                throw new ExceptionController(ExceptionMessage.WALL_ALREADY_EXSIST);
            }
        }

        private void ContainedIn(Grid grid, Wall wall)
        {
            foreach (Wall anotherWall in this.GetList(grid))
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

        public List<Wall> GetList(Grid grid)
        {
            return wallRepository.GetList(grid);
        }

        public void Remove(Grid grid, Wall intersectWall)
        {
            wallRepository.Remove(grid, intersectWall);
        }

        public List<Point> GetWallPath(Wall wall)
        {
            return wallRepository.GetWallPath(wall);
        }
    }
}
