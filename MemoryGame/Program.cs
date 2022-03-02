using MemoryGame;
using MemoryGame.Models;

public class Program
{
    public static void Main(string[] args)
    {
        WordsList wordsList = new();
        Boards board = new Boards(wordsList);
    }
}