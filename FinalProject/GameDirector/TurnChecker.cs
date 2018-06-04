using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FinalProject.MoveDirector;
using FinalProject.RunningTest;

namespace FinalProject.GameDirector
{
    class TurnChecker
    {
        SelectUnit selectUnit = new SelectUnit();
        Move move = new Move();
        ThrowYut throwYut = new ThrowYut();
        private bool _player1Moved = false;
        private bool _player1TurnEnd = false;
        private bool _player2Moved = false;
        private bool _player2TurnEnd = false;

        Random testRandom = new Random();
        RealMove realMove = new RealMove();

        TestUnit testUnit = new TestUnit();




        public void Player1Turn(List<double> player1, List<double> player2)
        {
            //TODO : 1윷던지기 2유닛선택 3이동 4.충돌 5.충돌결과 5.5스킵채크 6.턴종료

            realMove.ActualMove(player1);

            Thread.Sleep(500);

            //            int selectUnit = testRandom.Next(0, 4);
            //            int unitChose;

            //            switch (selectUnit)
            //            {
            //                case 0:
            //                    unitChose = 0;
            //                    break;
            //
            //                case 1:
            //                    unitChose = 1;
            //                    break;
            //
            //                case 2:
            //                    unitChose = 2;
            //                    break;
            //
            //                case 3:
            //                    unitChose = 3;
            //                    break;
            //            }
            //
            //            Console.WriteLine(selectUnit + "번" + " " + "유닛" + " " + "선택됨");


            Console.WriteLine("Player1" + " " + " Moved");

            Console.WriteLine("플레이어1의"+" "+"위치"+" : "+player1[0]);
            Console.WriteLine("---------------------");
            _player1Moved = true;
            _player1TurnEnd = true;

            if (_player1TurnEnd == true)
            {
                Player2Turn(player2);
                _player2TurnEnd = false;
            }

        }

        public void Player2Turn(List<double> player2)
        {
            Thread.Sleep(500);

            //            int selectUnit = testRandom.Next(0, 4);
            //            int unitChose;
   

            realMove.ActualMove(player2);


            //            switch (selectUnit)
            //            {
            //                case 0:
            //                    unitChose = 0;
            //                    break;
            //
            //                case 1:
            //                    unitChose = 1;
            //                    break;
            //
            //                case 2:
            //                    unitChose = 2;
            //                    break;
            //
            //                case 3:
            //                    unitChose = 3;
            //                    break;
            //            }

            //            Console.WriteLine(selectUnit + "번" + " " + "유닛" + " " + "선택됨");


            Console.WriteLine("Player2" + " " + " Moved");
          
            Console.WriteLine("플레이어2의" + " " + "위치" + " : " + player2[0]);
            Console.WriteLine("---------------------");
            _player2Moved = true;
            _player2TurnEnd = true;

            if (_player2TurnEnd == true)
            {
                _player1TurnEnd = false;
            }

            Thread.Sleep(500);
        }


    }
}
