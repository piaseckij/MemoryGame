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

            var board = new Boards(difficulty);
            TableView.ShowBoard(board);
        }
    }
}
