using Domain.Entities;
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
        private GridHandler gridHandler;
        private IDecorativeColumnRepository decorativeColumnRepository;

        public DecorativeColumnHandler(GridRepository gridRepository)
        {
            this.gridHandler = new GridHandler();
            this.decorativeColumnRepository = new DecorativeColumnRepository(gridRepository);
        }

        public void Add(Grid grid, DecorativeColumn decorativeColumn)
        {
            this.decorativeColumnRepository.Add(grid, decorativeColumn);
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
