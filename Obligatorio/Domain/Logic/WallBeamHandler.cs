using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Logic
{
    public class WallBeamHandler : IElementHandler<WallBeam>
    {

        private GridHandler gridHandler;
        private IWallBeamRepository wallBeamRepository;
        
        public void Add(Grid grid, WallBeam wallBeam)
        {
            wallBeam.GridId = gridHandler.Get(grid).GridId;
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
