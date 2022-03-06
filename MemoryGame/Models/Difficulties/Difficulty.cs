namespace MemoryGame.Models.Difficulties;

public interface IDifficulty
{
    int Tries { get; set; }
    int WordsNumber { get; set; }
    public string Name { get; }
}

public class Difficulty : IDifficulty
{
    public int Tries { get; set; }
    public int WordsNumber { get; set; }
    public string Name { get; } 
}