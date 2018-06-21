using Domain.Entities;
using Domain.Exceptions;
using Domain.Interface;
using Domain.Repositories;
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

        public WindowHandler(GridRepository gridRepository)
        {
            this.gridHandler = new GridHandler();
            this.windowRepository = new WindowRepository(gridRepository);
        }

        public void Add(Grid grid, Window window, PriceAndCost priceAndCost)
        {
            isValid(window);
            this.windowRepository.Add(grid, window, priceAndCost);
        }

        private void isValid(Window window)
        {
            if (NotDefault(window))
            {
                NotExist(window);
            }
            validSize(window);
        }

        private void validSize(Window window)
        {
            if(window.high + window.distanceFromGround > 3.00f)
            {
                throw new ExceptionController(ExceptionMessage.WINDOW_INVALID_SIZE);
            }
        }

        private void NotExist(Window window)
        {
            List<String> windowNames = windowRepository.GetNameList();
            if (windowNames.Contains(window.name))
            {
                throw new ExceptionController(ExceptionMessage.WINDOW_NAME_ALREADY_EXIST);
            }
        }

        private bool NotDefault(Window window)
        {
            return window.name != "default";
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
            return windowRepository.Exist(grid, window.StartPoint);
        }

        public int Count(Grid grid)
        {
            return windowRepository.Count(grid);
        }

        public Window GetFirst()
        {
            return windowRepository.GetFirst();
        }
    }

}
