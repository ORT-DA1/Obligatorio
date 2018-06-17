using Domain.Entities;
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
        private IDecorativeColumnRepository decorativeColumnRepository;
        public void Add(DecorativeColumn decorativeColumn)
        {
            this.decorativeColumnRepository.AddDecorativeColumn(decorativeColumn);
        }

    }
}
