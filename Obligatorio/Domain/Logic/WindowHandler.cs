using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class WindowHandler : IElementHandler<Window>
    {
        private GridHandler gridHandler;
        private IWindowRepository windowRepository;
        public void Add(Grid grid, Window window)
        {
            window.GridId = gridHandler.Get(grid).GridId;
            this.windowRepository.Add(grid, window);
        }

        public List<Window> GetList(Grid grid)
        {
            return windowRepository.GetList(grid);
        }

        public void Remove(Grid grid, Window window)
        {
            windowRepository.Remove(grid, window);
        }

        public bool Exist(Grid grid, Window window)
        {
            return windowRepository.Exist(grid, window);
        }

        public int Count(Grid grid)
        {
            return windowRepository.Count(grid);
        }
    }

}
