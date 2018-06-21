using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class GeneratedWindowHandler
    {
        GeneratedWindowRepository generatedWindowRepository;

        public GeneratedWindowHandler()
        {
            generatedWindowRepository = new GeneratedWindowRepository();
        }
        public List<GeneratedWindow> GetList()
        {
            return generatedWindowRepository.GetList();
        }

        public void Add(Architect architect, GeneratedWindow generatedWindow, PriceAndCost priceAndCost)
        {
            this.generatedWindowRepository.Add(architect, generatedWindow, priceAndCost);
        }

        public GeneratedWindow GetGeneratedWindow(GeneratedWindow generatedWindow)
        {
            return generatedWindowRepository.GetGeneratedWindow(generatedWindow);
        }
    }
}
