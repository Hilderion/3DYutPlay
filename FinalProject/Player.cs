using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        public List<Unit> unitInfo = new List<Unit>();
        int _turnCount;
        int _playerNumber;
        int _goalCount;
        bool _isSkipped;

        public void CreatePlayer(int playernumber) { }

        public void CreateUnits() { }

        public int SelectUnit()
        {
            //1~4 유닛 사이에서 하나를 선택
            return 1;
        }



    }
}
