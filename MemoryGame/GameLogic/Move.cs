﻿using MemoryGame.Models;
using MemoryGame.UserInterface;

namespace MemoryGame.GameLogic;

public static class Move
{
    public static List<Word> MakeMove(Boards board, List<UserSelection> userSelections)
    {
        var selectedWords = Select.SelectField(userSelections, board);
        
        return selectedWords;
    }


}