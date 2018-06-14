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

            board.게임판생성하기();
            player1.플레이어생성하기(1);
            player2.플레이어생성하기(2);

            _selectedUnit = player1.유닛선택하기();

            

        }

       

     

    }
}
