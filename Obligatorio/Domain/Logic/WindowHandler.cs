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
        private IWindowRepository windowRepository;
        public void Add(Grid grid, Window window)
        {
            this.windowRepository.AddWindow(grid, window);
        }

        public List<Window> GetList(Grid grid)
        {
            List<Window> windowList = windowRepository.GetAllWindows(grid);
            //
            return windowList;
        }
    }

}
