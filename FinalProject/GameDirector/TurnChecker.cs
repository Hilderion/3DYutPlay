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

        int playerTurnCounter1 = 1;
        int playerTurnCounter2 = 1;

        Random testRandom = new Random();
        RealMove realMove = new RealMove();

        TestUnit testUnit = new TestUnit();

        public void Player1Turn(List<double> player1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player1의"+" "+ playerTurnCounter1+ "번째 턴");

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
            _player1Moved = true;
            _player1TurnEnd = true;

//            if (_player1TurnEnd == true)
//            {
//                Player2Turn(player2);
//                _player2TurnEnd = false;
//            }

            playerTurnCounter1++;

            if (playerTurnCounter1>2 && player1[0] == 1 && player1[1] == 0 && player1[2] == 0)
            {
                Console.WriteLine("Player1 게임 끝");
                Console.WriteLine("소요턴"+" : "+playerTurnCounter1);
            }


        }

        public void Player2Turn(List<double> player2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player2의" + " " + playerTurnCounter2 + "번째 턴");

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
            _player2Moved = true;
            _player2TurnEnd = true;

            if (_player2TurnEnd == true)
            {
                _player1TurnEnd = false;
            }

            playerTurnCounter2 ++;

            if (playerTurnCounter2 > 2 && player2[0] == 1 && player2[1] == 0 &&player2[2] == 0)
            {
                Console.WriteLine("Player1 게임 끝");
                Console.WriteLine("소요턴" + " : " + playerTurnCounter2);
            }

        }


    }
}
