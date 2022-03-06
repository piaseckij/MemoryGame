using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models;

namespace MemoryGame
{
    public class FileHandling
    {

        public static List<string> ReadWordsFromFile()
        {
            List<string> _wordsFromFile = new();

            foreach (var line in File.ReadAllLines(@"..\..\..\Resources\Words.txt"))
                _wordsFromFile.Add(line);

            return _wordsFromFile;
        }

       
    }
}
