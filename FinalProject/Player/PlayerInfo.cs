using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Player
{
    class PlayerInfo : Unit.Unit
    {
        //유닛, 턴스킵여부, 유닛골현황, 윷 던진여부, 유닛 선택여부
        List<Unit.Unit> playerUnits = new List<Unit.Unit>();
        bool isSkipped;
        bool isThrowed;
        int playerTurn;

        public void goalStatus() { }

        //

    }
}
