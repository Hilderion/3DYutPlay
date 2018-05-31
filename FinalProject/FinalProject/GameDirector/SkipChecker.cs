using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class SkipChecker
    {
        public bool _turnSkip;
        PointTypeChecker pointTypeChecker = new PointTypeChecker();

        public void TurnCheck()
        {
            if (_turnSkip == true)
            {
                // TODO :해당 플레이어의 턴을 끝내도록 입력, 플레이어별 턴 구현
                _turnSkip = false;
                return;
            }

            else if (pointTypeChecker.PointTypeCheck() == "Well" && _turnSkip == false)
            {
                _turnSkip = true;

            }

        }

    }
}
