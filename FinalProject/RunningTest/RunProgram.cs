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

            Player p1 = new Player();
            Player p2 = new Player();

            TurnChecker actualGame = new TurnChecker();
            p1.MakePlayer(1);
            p2.MakePlayer(1);

            for (int i = 0; i < 5; i++)
            {
                actualGame.Player1Turn(p1);
                actualGame.Player2Turn(p2);
            }

        }
    }
}
