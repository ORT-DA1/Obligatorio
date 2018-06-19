﻿using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class DecorativeColumnHandler : IElementHandler<DecorativeColumn>
    {
        private GridHandler gridHandler;
        private IDecorativeColumnRepository decorativeColumnRepository;
        public void Add(Grid grid, DecorativeColumn decorativeColumn)
        {
            decorativeColumn.GridId = gridHandler.Get(grid).GridId;
            this.decorativeColumnRepository.Add(grid, decorativeColumn);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            return decorativeColumnRepository.GetList(grid);
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            decorativeColumnRepository.Remove(grid, decorativeColumn);
        }

        public bool Exist(Grid grid, DecorativeColumn decorativeColumn)
        {
            return decorativeColumnRepository.Exist(grid, decorativeColumn); 
        }

        public int Count(Grid grid)
        {
            return decorativeColumnRepository.Count(grid);
        }
    }
}
