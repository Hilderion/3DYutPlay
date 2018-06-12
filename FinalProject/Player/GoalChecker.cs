using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Player
{
    class GoalChecker
    {
        public int _player1GoalCount = 0;
        public int _player2GoalCount = 0;


        //골 지점에 도착했을때 GoalCheck()를 실행
        public void GoalCheck()
        {

        }

        public void GameWinCheck()
        {
            if (_player1GoalCount >= 4)
            {
                // TODO : 플레이어 1 게임 승리 구현
                Console.WriteLine("Player 1 win");
            }

            if (_player2GoalCount >= 4)
            {
                // TODO : 플레이어 2 게임 승리 구현
                Console.WriteLine("Player 2 win");
            }
        }
    }
}
