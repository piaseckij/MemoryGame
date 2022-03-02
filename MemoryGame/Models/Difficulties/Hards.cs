using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Models.Difficulties
{
    public class Hards:IDifficulty
    {
        public int Tries { get; set; } = 15;
        public int WordsNumber { get; set; } = 8;
    }
}
