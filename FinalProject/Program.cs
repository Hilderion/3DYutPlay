using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        Board board = new Board();
        Player player1 = new Player();
        Player player2 = new Player();
        Yut yut = new Yut();

        int selectedunit;


        public void Main()
        {
            board.CreateBoard();
            player1.CreatePlayer(1);
            player2.CreatePlayer(2);

            selectedunit = player1.SelectUnit();

            player1.unitInfo[selectedunit].Move(yut.ThrowYut());
            board.Excute();

        }
    }
}
