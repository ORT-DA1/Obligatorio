using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class DecorativeColumnHandler : IElementHandler<DecorativeColumn>
    {
        private IDecorativeColumnRepository decorativeColumnRepository;
        public void Add(Grid grid, DecorativeColumn decorativeColumn)
        {
            this.decorativeColumnRepository.Add(grid, decorativeColumn);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            List<DecorativeColumn> decorativeColumnList = decorativeColumnRepository.GetList(grid);
            return decorativeColumnList;
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            decorativeColumnRepository.Remove(grid, decorativeColumn);
        }

        public bool Exist(Grid grid, DecorativeColumn decorativeColumn)
        {
            return decorativeColumnRepository.Exist(decorativeColumn); 
        }

        public int Count(Grid grid)
        {
            return decorativeColumnRepository.Count(grid);
        }
    }
}
