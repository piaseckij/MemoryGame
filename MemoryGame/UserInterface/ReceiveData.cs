using MemoryGame.Exceptions;
using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public class ReceiveData
{
    public static UserSelection Receive()
    {
        Console.WriteLine("Select Field: ");
        var input = Console.ReadLine();

        if (input is null) throw new NullInputException("Input cannot be null");

        var row = input[0];

        var success = int.TryParse("" + input[1], out var column);
        if (success)
        {
            return new UserSelection(row, column);
        }

        Console.WriteLine("Bad Input");
        throw new BadInputException("Wrong Input");
    }
}