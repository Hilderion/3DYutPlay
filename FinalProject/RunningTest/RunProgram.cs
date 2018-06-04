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

            TurnChecker actualGame = new TurnChecker();

            for (int i = 0; i < 2; i++)
            {
                actualGame.Player1Turn();
            }

        }
    }
}
