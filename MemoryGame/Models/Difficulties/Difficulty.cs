using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Models.Difficulties
{
    public interface IDifficulty
    {
        int Tries { get; set; }
        int WordsNumber { get; set; }
    }

    public class Difficulty : IDifficulty
    {   
        public int Tries { get; set; }
        public int WordsNumber { get; set; }
    }
}
