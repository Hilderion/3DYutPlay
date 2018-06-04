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


            TurnChecker actualGame = new TurnChecker();

            for (int i = 0; i < 2; i++)
            {
                actualGame.Player1Turn(testBot1,testBot2);
                //위에걸 불러와야 하는데 안됨 지금.

//                actualGame.Player1Turn(test1, test2);
            }

        }
    }
}
