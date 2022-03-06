using MemoryGame.GameLogic;
using MemoryGame.UserInterface;

namespace MemoryGame;

public class Program
{
    public static void Main(string[] args)
    {
        HighScoresHandling.WriteScores();
        var game = new Game();
        game.StartGame();
        game = null;
        if (ReceiveData.RestartQuestion())
        {
            game = new Game();
            game.StartGame();
        }
    }
}