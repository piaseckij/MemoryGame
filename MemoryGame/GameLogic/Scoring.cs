using System.Diagnostics;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.GameLogic;

public class Scoring
{
    private readonly Stopwatch _stopWatch;

    public Scoring(IDifficulty difficulty)
    {
        _stopWatch = new Stopwatch();
        Difficulty = difficulty;
    }

    private IDifficulty Difficulty { get; set; }

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