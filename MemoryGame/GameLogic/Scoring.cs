using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.GameLogic
{
    public class Scoring
    {
        private readonly Stopwatch _stopWatch;
        public IDifficulty Difficulty { get; set; }
        public Scoring(IDifficulty difficulty)
        {
            _stopWatch=new Stopwatch();
            Difficulty= difficulty;

        }
        public void StartScoring()
        {
            _stopWatch.Start();
        }

        public int StopScoring()
        {
            return (int) _stopWatch.ElapsedMilliseconds / 1000;
        }

        public void RemoveTry()
        {
            Difficulty.Tries--;
        }


    }
}
