using MemoryGame.Models.Difficulties;

namespace MemoryGame.Models;

public class Boards
{
    private readonly WordsList _wordsList;
    public List<List<Word>> Board = new();

    public Boards( IDifficulty difficulty)
    {
        _wordsList = new WordsList(difficulty);
        FillTheBoard(_wordsList);
    }

    public void FillTheBoard(WordsList words)
    {
        var rnd = new Random();
        for (var i = 0; i < 2; i++)
        {
            var row = new List<Word>();

            for (var j = 0; j < words.Words.Count; j++)
            {
                row.Add(new Word(_wordsList.Words[j]));
            }
            Board.Add(row);
        }
    }
}