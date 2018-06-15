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
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            Yut yut = new Yut();

            int _selectedUnit;

            board.게임판생성하기();
           
            _selectedUnit = player1.유닛선택하기();

            

        }
        
    }
}
