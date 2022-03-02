﻿using MemoryGame;
using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

public class Program
{
    public static void Main(string[] args)
    {
        WordsList wordsList = new();
        Easy easy = new();
        var board = new Boards(wordsList, easy);
    }
}