﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Exceptions
{
    public class BadInputException:Exception
    {
        public BadInputException(string message):base(message)
        {
            
        }
    }
}
