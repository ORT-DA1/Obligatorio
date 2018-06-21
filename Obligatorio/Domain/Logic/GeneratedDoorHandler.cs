using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class GeneratedDoorHandler
    {
        GeneratedDoorRepository generatedDoorRepository;

        public GeneratedDoorHandler()
        {
            generatedDoorRepository = new GeneratedDoorRepository();
        }
        public List<GeneratedDoor> GetList()
        {
            return generatedDoorRepository.GetList();
        }

        public void Add(Architect architect, GeneratedDoor generatedDoor, PriceAndCost priceAndCost)
        {
            this.generatedDoorRepository.Add(architect, generatedDoor, priceAndCost);
        }

        public GeneratedDoor GetGeneratedDoor(GeneratedDoor generatedDoor)
        {
            return generatedDoorRepository.GetGeneratedDoor(generatedDoor);
        }
    }
}
