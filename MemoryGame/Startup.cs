using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models;
using MemoryGame.Models.Difficulties;
using MemoryGame.UserInterface;

namespace MemoryGame
{
    public class Startup
    {
        public void Start()
        {
            var difficulty = ReceiveData.ReceiveDifficulty();
            var words = new WordsList(difficulty);
            var board = new Boards(words, difficulty);
            TableView.ShowBoard(board);
        }
    }
}
