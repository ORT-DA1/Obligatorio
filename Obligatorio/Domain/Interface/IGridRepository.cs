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
        void AddGrid(Grid grid, Client client);
        void DeleteGrid(Grid grid);
        Grid GetGrid(Grid grid);
        List<Grid> GetAllGrids();
        void AddWall(Grid grid, Wall wall);
        void AddWallBeam(Grid grid, WallBeam wallBeam);
        void AddWindow(Grid grid, Window window);
        void AddDoor(Grid grid, Door door);
        void AddDecorativeColumn(Grid grid, DecorativeColumn decorativeColumn);
        Grid ReadGrid(Grid grid);
        bool Exist(Grid grid);
        List<Signature> GetSignatures(Grid grid);
        void SaveSignature(Grid grid, Signature signature);
    }
}
