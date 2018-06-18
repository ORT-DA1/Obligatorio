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
            this.decorativeColumnRepository.AddDecorativeColumn(grid, decorativeColumn);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            List<DecorativeColumn> decorativeColumnList = decorativeColumnRepository.GetAllDecorativeColumns(grid);
            //
            return decorativeColumnList;
        }
    }
}
