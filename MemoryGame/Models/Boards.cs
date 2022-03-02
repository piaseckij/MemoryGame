namespace MemoryGame.Models;

public class Boards
{
    private readonly WordsList _wordsList;
    public List<Word> Board = new();

    public Boards(WordsList wordsList)
    {
        _wordsList = wordsList;
        FillTheBoard();
    }

    public void FillTheBoard()
    {
        var rnd = new Random();
        for (var i = 0; i < 10; i++)
        {
            Board.Add(_wordsList.Words[rnd.Next(1, 100)]);
            Console.WriteLine(Board);
        }
    }
}