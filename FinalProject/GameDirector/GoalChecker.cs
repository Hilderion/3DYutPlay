using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class GoalChecker
    {
        public int _player1GoalCount = 0;
        public int _player2GoalCount = 0;

        #region playerUnits
        Unit _player1UnitKnight = new Unit(1, UnitTag.Knight);
        Unit _player1UnitHeavySoldier = new Unit(1, UnitTag.HeavySoldier);
        Unit _player1UnitGuard = new Unit(1, UnitTag.Guard);
        Unit _player1UnitScout = new Unit(1, UnitTag.Scout);

        Unit _player2UnitKnight = new Unit(2, UnitTag.Knight);
        Unit _player2UnitHeavySoldier = new Unit(2, UnitTag.HeavySoldier);
        Unit _player2UnitGuard = new Unit(2, UnitTag.Guard);
        Unit _player2UnitScout = new Unit(2, UnitTag.Scout);
        #endregion
        
        //골 지점에 도착했을때 GoalCheck()를 실행
        public void GoalCheck()
        {
            if (_player1UnitScout.isGoaled == true
                || _player1UnitHeavySoldier.isGoaled == true
                || _player1UnitGuard.isGoaled == true
                || _player1UnitScout.isGoaled == true)
                _player1GoalCount++;

            if (_player2UnitScout.isGoaled == true
                || _player2UnitHeavySoldier.isGoaled == true
                || _player2UnitGuard.isGoaled == true
                || _player2UnitScout.isGoaled == true)
                _player2GoalCount++;
        }

        public void EndCheck()
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
