using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.UserInterface
{
    public class HighScoresHandling
    {
        public static void WriteScores( )
        {
            Console.WriteLine("\n\n!HIGH SCORES!\n\n");

            var scoresFromFile = FileHandling.ReadScores();
            foreach (var line in scoresFromFile)
            {
                string[] subs = line.Split("|");
                foreach (var sub in subs)
                {
                    Console.Write(sub+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
