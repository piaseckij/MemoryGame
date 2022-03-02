using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Models
{
    public class UserSelection
    {
        public char Line { get; set; }
        public int Column { get; set; }

        public UserSelection(char line, int column)
        {
            Line = line;
            Column = column;
        }
    }
}
