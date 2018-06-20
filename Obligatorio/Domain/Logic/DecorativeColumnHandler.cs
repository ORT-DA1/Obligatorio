using Domain.Entities;
using Domain.Exceptions;
using Domain.Interface;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class DecorativeColumnHandler : IElementHandler<DecorativeColumn>
    {
        //private WallHandler wallHandler;

        private WallRepository wallRepository;
        private IDecorativeColumnRepository decorativeColumnRepository;

        public DecorativeColumnHandler(GridRepository gridRepository)
        {
            //this.wallHandler = new WallHandler(gridRepository);
            this.wallRepository = new WallRepository(gridRepository);
            this.decorativeColumnRepository = new DecorativeColumnRepository(gridRepository);
        }

        public void Add(Grid grid, DecorativeColumn decorativeColumn)
        {
            this.IsValid(grid, decorativeColumn);
            this.decorativeColumnRepository.Add(grid, decorativeColumn);
        }

        private void IsValid(Grid grid, DecorativeColumn decorativeColumn)
        {
            Point point = new Entities.Point(decorativeColumn.UbicationPoint.X, decorativeColumn.UbicationPoint.Y);
            if (this.ObtainWallInPoint(grid, point) != null)
            {
                throw new ExceptionController(ExceptionMessage.DECORATIVECOLUMN_INVALID);
            }
        }

        private object ObtainWallInPoint(Grid grid, Point point)
        {
            return wallRepository.ObtainWallInPoint(grid, point);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            return decorativeColumnRepository.GetList(grid);
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            decorativeColumnRepository.Remove(grid, decorativeColumn);
        }

        public bool Exist(Grid grid, DecorativeColumn decorativeColumn)
        {
            return decorativeColumnRepository.Exist(grid, decorativeColumn.UbicationPoint);
        }

        public int Count(Grid grid)
        {
            return decorativeColumnRepository.Count(grid);
        }
    }
}
