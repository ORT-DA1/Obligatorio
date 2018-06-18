using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IDecorativeColumnRepository
    {
        void AddDecorativeColumn(Grid grid, DecorativeColumn decorativeColumn);
        List<DecorativeColumn> GetAllDecorativeColumns(Grid grid);
    }
}
