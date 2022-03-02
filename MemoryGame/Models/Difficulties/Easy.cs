using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Models.Difficulties
{
    public class Easy:IDifficulty
    {
        public int Tries { get; set; } = 10;
        public int WordsNumber { get; set; } = 4;
    }
}
