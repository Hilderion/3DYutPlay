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
    class RealMove
    {
        MapPoint.Move move = new Move();

        MapPoint.CheckDirectionSelect checkDirectionSelect = new MapPoint.CheckDirectionSelect();
        int _result;
        int _checkeddirection=1;

        public void ActualMove(List<double> testUnit)
        {
            ThrowResult throwresult = new ThrowResult();
            _result = throwresult.AfterThrow();

            for (int i = 0; i < _result; i++)
            {
                _checkeddirection = checkDirectionSelect.CheckDirection(testUnit, _checkeddirection);

                testUnit = move.Directionsetting(testUnit, _checkeddirection);

                Console.WriteLine(testUnit[0] + " " + testUnit[1] + " " +testUnit[2]);
            }

        }

    }
}

