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
            TestUnit testUnit = new TestUnit();
            MoveDirector.Move move = new MoveDirector.Move();
            HowToGo going = new HowToGo();
            
            for (int i = 0; i < 9; i++)
            {
                going.Directionsetting(testUnit.TestBot(), 1);

                Console.WriteLine(testUnit.TestBot()[0] + " " + testUnit.TestBot()[0] + " " + testUnit.TestBot()[0]);
            }

            


        }
    }
}
