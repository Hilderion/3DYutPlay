using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class TurnCounter
    {
        private int player1TurnCount = 1;
        private int player2TurnCount = 1;

        public int Player1Turn
        {
            get { return player1TurnCount; }

            set { player1TurnCount = value; }
        }

        public int Player2Turn
        {
            get { return player2TurnCount; }

            set { player2TurnCount = value; }
        }

    }
}
