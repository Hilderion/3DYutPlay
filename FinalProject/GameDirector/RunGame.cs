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
    class RunGame
    {
        private bool _player1Moved = false;
        private bool _player1TurnEnd = false;
        private bool _player2Moved = false;
        private bool _player2TurnEnd = false;

        int playerTurnCounter1 = 1;
        int playerTurnCounter2 = 1;
        int result;
        Unit Player1Unit = null;
        Unit Player2Unit = null;

        RealMove realMove = new RealMove();
        ThrowResult throwResult = new ThrowResult();
        NeedToMove needToMove = new NeedToMove();
        ThrowYut throwYut = new ThrowYut();
        GetAndSetUnit unitSet = new GetAndSetUnit();

        public void Player1Turn(Player player1)
        {
            
            Console.WriteLine("----------------------");
            Console.WriteLine("player1의" + " " + playerTurnCounter1 + "번째 턴");

            //TODO : 1윷던지기 2유닛선택 3이동 4.충돌 5.충돌결과 5.5스킵채크 6.턴종료

            result = throwResult.AfterThrow(); //윳 던지기
            throwYut.Throwcheck(); //윳 던진걸 체크

            if (unitSet.SetUnit() == 1) //TODO: 이중 선택되는 문제 해결할것!
            {
                Player1Unit = player1.Knight;
            }
            else if (unitSet.SetUnit() == 2)
            {
                Player1Unit = player1.HeavySoldier;
            }
            else if (unitSet.SetUnit() == 3)
            {
                Player1Unit = player1.Guard;
            }
            else if (unitSet.SetUnit() == 4)
            {
                Player1Unit = player1.Scout;
            }


            Start:
            unitSet.isSelectUnitResult(Player1Unit); //Knight 선택

            if (needToMove.NeedToMoveResult(Player1Unit, throwYut) != true)
                goto Start;
            // 윷 던져졌나, 유닛 체크 되었나 확인하는 과정.

            Console.WriteLine("[윷값:" + result + "]");

            realMove.ActualMove(Player1Unit, result, Player1Unit.direction);
            Player1Unit.direction = realMove._checkeddirection;

            Console.WriteLine("Player1" + " " + " Moved");

            Console.WriteLine("플레이어1의" + " " + "위치" + " : " + Player1Unit.UnitPosition[0] + " " +
                              Player1Unit.UnitPosition[1] + " " + Player1Unit.UnitPosition[2]);
            _player1Moved = true;
            _player1TurnEnd = true;

            playerTurnCounter1++;


        }

        public void Player2Turn(Player player2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player2의" + " " + playerTurnCounter2 + "번째 턴");

            if (unitSet.SetUnit() == 1)
            {
                Player2Unit = player2.Knight;
            }
            else if (unitSet.SetUnit() == 2)
            {
                Player2Unit = player2.HeavySoldier;
            }
            else if (unitSet.SetUnit() == 3)
            {
                Player2Unit = player2.Guard;
            }
            else if (unitSet.SetUnit() == 4)
            {
                Player2Unit = player2.Scout;
            }

            Start:
                unitSet.isSelectUnitResult(Player2Unit); //Knight 선택
                result = throwResult.AfterThrow(); //윳 던지기
                throwYut.Throwcheck(); //윳 던진걸 체크
                
                if (needToMove.NeedToMoveResult(Player2Unit, throwYut) != true)
                    goto Start;

                Console.WriteLine("[윷값:" + result + "]");

                realMove.ActualMove(Player2Unit, result, Player2Unit.direction);
                Player2Unit.direction = realMove._checkeddirection;


                Console.WriteLine("Player2" + " " + " Moved");

                Console.WriteLine("플레이어2의" + " " + "위치" + " : " + Player2Unit.UnitPosition[0] + " " +
                                  Player2Unit.UnitPosition[1] + " " + Player2Unit.UnitPosition[2]);
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

