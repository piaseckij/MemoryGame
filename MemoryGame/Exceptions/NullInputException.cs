using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Exceptions
{
    public class NullInputException:Exception
    {
               
        public NullInputException(string message):base(message)
        {
            
        }
    }
}
