using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FinalProject.MoveDirector;
using Move = FinalProject.MapPoint.Move;

namespace FinalProject.RunningTest
{
    class RunProgram
    {
        static void Main(string[] args)
        {
            MapPoint.Move movingTest = new Move();
            TestUnit testBot = new TestUnit();
            ThrowYut th = new ThrowYut();
            MoveDirector.Move move = new MoveDirector.Move();
            int str;
            str =
                move.RealMove(th.ThrowYutResult());

            if (str == 1)
            {
                movingTest.Directionsetting(testBot.getPosition(), testBot.getDirection());
            }
       

        }
    }
}
