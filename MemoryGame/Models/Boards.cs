using MemoryGame.Models.Difficulties;

namespace MemoryGame.Models;

public class Boards
{
    private readonly WordsList _wordsList;
    public readonly List<List<Word>> Board = new();

    public Boards(IDifficulty difficulty)
    {
        _wordsList = new WordsList(difficulty);
        FillTheBoard();
        RandomizeBoard();
    }

    private void FillTheBoard()
    {
        var rnd = new Random();
        for (var i = 0; i < 2; i++)
        {
            var row = _wordsList.Words.Select(t => new Word(t)).ToList();

            Board.Add(row);
        }
    }

    private void RandomizeBoard()
    {
        var rnd = new Random();

        for (var i = 0; i < Board.Count; i++)
        {
            var newRow = Board[i].OrderBy(item => rnd.Next());
            var temp = newRow.ToList();

            Board[i] = temp;
        }
    } 
}