using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FinalProject.GameDirector;
using FinalProject.MoveDirector;
using Move = FinalProject.MapPoint.Move;

namespace FinalProject.RunningTest
{
    class RunProgram
    {
        static void Main(string[] args)
        {
            TestUnit testUnit = new TestUnit();

            List<double> testBot1 = testUnit.TestBot();
            List<double> testBot2 = testUnit.TestBot2();
            // 19-20에 새로 각 플레이어의 유닛을 추가하고

            Unit u1 = new Unit(0, UnitTag.Knight);
            Unit u2 = new Unit(1, UnitTag.Knight);


            TurnChecker actualGame = new TurnChecker();


            for (int i = 0; i < 5; i++)
            {
                actualGame.Player1Turn(testBot1);
                // 27에 플레이어1,플레이어2를 넣으면 구동한다.
                actualGame.Player2Turn(testBot2);

//                actualGame.Player1Turn(u1.UnitPosition);
            }

        }
    }
}
