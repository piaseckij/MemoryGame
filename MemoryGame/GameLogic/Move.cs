using MemoryGame.Models;
using MemoryGame.Models.Difficulties;
using MemoryGame.UserInterface;

namespace MemoryGame.GameLogic;

public class Move
{
    public static bool MakeMove(Boards board)
    {
         
        var selectedWord1=Select.SelectField(ReceiveData.ReceiveField(), board);
        var selectedWord2 = Select.SelectField(ReceiveData.ReceiveField(), board);

        if (selectedWord1.Equals(selectedWord2))
        {
            return true;
        }
        return false;
    }
}