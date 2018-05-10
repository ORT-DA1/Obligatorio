﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    class ExceptionController: Exception
    {
        public ExceptionController(): base(){ }

        public ExceptionController(string message) : base(message) { }

        public ExceptionController(string message, Exception innerException)
            : base(message, innerException){ }
    }
}
