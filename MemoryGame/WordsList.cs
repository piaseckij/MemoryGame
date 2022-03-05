using MemoryGame.Models.Difficulties;

namespace MemoryGame;

public class WordsList
{
    private readonly List<string> _wordsFromFile = new();


    public readonly List<string> Words = new();

    public WordsList(IDifficulty difficulty)
    {
        ReadWordsFromFile();
        SelectWordsForGame(difficulty);
    }


    private void ReadWordsFromFile()
    {

        foreach (var line in File.ReadAllLines(@"..\..\..\Resources\Words.txt"))
            _wordsFromFile.Add(line);
    }

    private void SelectWordsForGame(IDifficulty difficulty)
    {
        var rnd = new Random();
        List<int> wordIndex = new();
        var k = 0;
        do
        {
            var index = rnd.Next(1, 100);
            if (!wordIndex.Contains(index))
            {
                wordIndex.Add(index);
                k++;
            }
        } while (k < difficulty.WordsNumber);

        for (var i = 0; i < difficulty.WordsNumber; i++)
        {
            var currentIndex = wordIndex[i];
            Words.Add(_wordsFromFile[currentIndex]);
        }
    }
}