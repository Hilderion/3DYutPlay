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
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player();
            Player player2 = new Player();
            Yut yut = new Yut();

            int _selectedUnit;

            board.CreateBoard();
            player1.CreatePlayer(1);
            player2.CreatePlayer(2);

            _selectedUnit = player1.SelectUnit();

            player1.UnitInfo[_selectedUnit].Move(yut.ThrowYut());
            board.Excute();
        }
    }
}
