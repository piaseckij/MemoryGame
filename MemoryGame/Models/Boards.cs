﻿using MemoryGame.Models.Difficulties;

namespace MemoryGame.Models;

public class Boards
{
    private readonly WordsList _wordsList;
    public List<Word> Board = new();

    public Boards(WordsList wordsList, IDifficulty difficulty)
    {
        _wordsList = wordsList;
        FillTheBoard(difficulty.WordsNumber);
    }

    public void FillTheBoard(int wordsNumber)
    {
        int[] wordIndex = new int[20];
        var rnd = new Random();
        for (var i = 0; i < wordsNumber; i++)
        {
            wordIndex[i] = rnd.Next(1, 100);
            Board.Add(_wordsList.Words[wordIndex[i]]);
            Board.Add(_wordsList.Words[wordIndex[i]]);

        }
    }
}