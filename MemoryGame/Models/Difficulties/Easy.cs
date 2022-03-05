namespace MemoryGame.Models.Difficulties;

public class Easy : IDifficulty
{
    public int Tries { get; set; } = 10;
    public int WordsNumber { get; set; } = 4;
    public string Name { get; } = "Easy";
}