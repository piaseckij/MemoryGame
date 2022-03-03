﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Models.Difficulties
{
    public class Hard:IDifficulty
    {
        public int Tries { get; set; } = 15;
        public int WordsNumber { get; set; } = 8;
        public string Name { get; } = "Hard";
    }
}
