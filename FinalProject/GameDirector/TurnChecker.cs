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
        private bool _player1Moved = false;
        private bool _player1TurnEnd = false;
        private bool _player2Moved = false;
        private bool _player2TurnEnd = false;

        int playerTurnCounter1 = 1;
        int playerTurnCounter2 = 1;
        int result;
        

        RealMove realMove = new RealMove();
        SelectUnit selectUnit = new SelectUnit();
        ThrowResult throwResult = new ThrowResult();
        NeedToMove needToMove = new NeedToMove();
        ThrowYut throwYut = new ThrowYut();


        public void Player1Turn(Player player1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player1의"+" "+ playerTurnCounter1+ "번째 턴");


            //TODO : 1윷던지기 2유닛선택 3이동 4.충돌 5.충돌결과 5.5스킵채크 6.턴종료

            
            Start: selectUnit.isSelectUnitResult(player1.Knight);//Knight 선택
            result = throwResult.AfterThrow();//윳 던지기
            throwYut.Throwcheck();//윳 던진걸 체크

            if (needToMove.NeedToMoveResult(player1.Knight, throwYut) != true)
                goto Start;    

            Console.WriteLine("[윷값:"+result+"]");

            realMove.ActualMove(player1.Knight, result, player1.Knight.direction);
            player1.Knight.direction = realMove._checkeddirection;

            Thread.Sleep(500);

            Console.WriteLine("Player1" + " " + " Moved");

            Console.WriteLine("플레이어1의"+" "+"위치"+" : "+ player1.Knight.UnitPosition[0] + " " + player1.Knight.UnitPosition[1] + " " + player1.Knight.UnitPosition[2]);
            _player1Moved = true;
            _player1TurnEnd = true;

            playerTurnCounter1++;

           
        }

        public void Player2Turn(Player player2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player2의" + " " + playerTurnCounter2 + "번째 턴");

            Start: selectUnit.isSelectUnitResult(player2.Knight);//Knight 선택
            result = throwResult.AfterThrow();//윳 던지기
            throwYut.Throwcheck();//윳 던진걸 체크

            if (needToMove.NeedToMoveResult(player2.Knight, throwYut) != true)
                goto Start;

            Console.WriteLine("[윷값:" + result + "]");

            realMove.ActualMove(player2.Knight, result, player2.Knight.direction);
            player2.Knight.direction = realMove._checkeddirection;

            Thread.Sleep(500);

            Console.WriteLine("Player2" + " " + " Moved");

            Console.WriteLine("플레이어2의" + " " + "위치" + " : " + player2.Knight.UnitPosition[0] + " " + player2.Knight.UnitPosition[1] + " " + player2.Knight.UnitPosition[2]);
            _player2Moved = true;
            _player2TurnEnd = true;

            playerTurnCounter2++;

            //if (playerTurnCounter2 > 2 && player2[0] == 1 && player2[1] == 0 &&player2[2] == 0)
            //{
            //    Console.WriteLine("Player1 게임 끝");
            //    Console.WriteLine("소요턴" + " : " + playerTurnCounter2);
            //}

        }


    }
}
