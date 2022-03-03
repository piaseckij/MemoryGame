using MemoryGame.Exceptions;
using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.UserInterface;

public class ReceiveData
{
    public static List<UserSelection> ReceiveField()
    {
        List<UserSelection> output = new();
        for (var i = 0; i < 2; i++)
        {
            Console.WriteLine("Select Field: ");
            var input = Console.ReadLine();

            if (input is null) throw new NullInputException("Input cannot be null");

            var row = input[0];
            var success = int.TryParse("" + input[1], out var column);
            if (!success)
            {
                Console.WriteLine("Bad Input");
                throw new BadInputException("Wrong Input");
            }

            output.Add(new UserSelection(row, column));
        }

        return output;
    }

    public static IDifficulty ReceiveDifficulty()
    {
        Console.WriteLine("What Difficulty you want?");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Hard");

        var input = Console.ReadLine();

        if (input is null)
        {
            Console.WriteLine("Input cannot be null");
            throw new NullInputException("Input cannot be empty");
        }

        var success = int.TryParse(input, out var level);
        if (!success || level.ToString().Length! > 1)
        {
            Console.WriteLine("Wrong input");
            throw new BadInputException("Wrong Input");
        }

        switch (level)
        {
            case 1:
                return new Easy();
            case 2:
                return new Hard();
        }

        throw new BadInputException("Wrong Input");
    }
}