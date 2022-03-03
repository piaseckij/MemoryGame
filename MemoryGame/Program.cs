using MemoryGame;
using MemoryGame.Models;
using MemoryGame.Models.Difficulties;
using MemoryGame.UserInterface;

public class Program
{
    public static void Main(string[] args)
    {
        Easy easy = new();
        WordsList words = new WordsList(easy);
        var board = new Boards(words, easy);
        TableView.ShowBoard(board);

        //ReceiveData.Receive();
    }
}