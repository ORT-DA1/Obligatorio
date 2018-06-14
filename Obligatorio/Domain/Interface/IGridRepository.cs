using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IGridRepository
    {
        void AddGrid(Grid grid);
        void ModifyGrid(Grid gridToModify, Grid modifiedGrid);
        void DeleteGrid(Grid grid);
        //Grid GetGrid(Grid grid);
        //List<Grid> GetAllGrids();
    }
}
