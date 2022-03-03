using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

namespace MemoryGame;

public class WordsList
{
    private readonly List<string> _wordsFromFile = new();
    public List<Word> Words = new();

    public WordsList(IDifficulty difficulty)
    {
        ReadWordsFromFile();
        SelectWordsForGame(difficulty);
    }


    private void ReadWordsFromFile()
    {
        //ToDo Zmienić ścieżkę
        foreach (var line in File.ReadAllLines(@"C:\Users\Kuba\source\repos\MemoryGame\MemoryGame\Resources\Words.txt"))
            _wordsFromFile.Add(line);
    }

    public void SelectWordsForGame(IDifficulty difficulty)
    {
        var rnd = new Random();
        for (var i = 0; i < difficulty.WordsNumber; i++)
            Words.Add(new Word(_wordsFromFile[rnd.Next(1, 100)]));
    }
}