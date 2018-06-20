using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;

namespace Domain.Logic
{
    public class WallBeamHandler : IElementHandler<WallBeam>
    {
        private GridHandler gridHandler;
        private IWallBeamRepository wallBeamRepository;

        public WallBeamHandler()
        {
            this.gridHandler = new GridHandler();
            this.wallBeamRepository = new WallBeamRepository();
        }

        public void Add(Grid grid, WallBeam wallBeam)
        {
            //wallBeam.Grid = gridHandler.Get(grid);
            this.wallBeamRepository.Add(grid, wallBeam);
        }

        public List<WallBeam> GetList(Grid grid)
        {
            return wallBeamRepository.GetList(grid);
        }

        public WallBeam GetWallBeam(Grid grid, Point startUbicationPoint)
        {
            WallBeam wallBeamToFind = new WallBeam(startUbicationPoint);
            return wallBeamRepository.Get(grid, wallBeamToFind);
        }

        public void Remove(Grid grid, WallBeam wallBeam)
        {
            wallBeamRepository.Remove(grid, wallBeam);
        }

        public int Count(Grid grid)
        {
            return wallBeamRepository.Count(grid);
        }
    }
}
