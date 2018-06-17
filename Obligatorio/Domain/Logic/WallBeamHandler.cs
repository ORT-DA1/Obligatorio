

using Domain.Entities;
using Domain.Interface;

namespace Domain.Logic
{
    public class WallBeamHandler : IElementHandler<WallBeam>
    {
        private IWallBeamRepository wallBeamRepository;
        public void Add(WallBeam wallBeam)
        {
            this.wallBeamRepository.AddWallBeam(wallBeam);
        }
    }
}
