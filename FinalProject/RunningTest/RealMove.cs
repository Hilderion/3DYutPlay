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
        HowToGo going = new HowToGo();
        MapPoint.CheckDirectionSelect checkDirectionSelect = new MapPoint.CheckDirectionSelect();
        int _throwYutResult;


        public List<int> ActualMove(List<int> testUnit, int checkeddirection)
        {

            ThrowYut throwYut = new ThrowYut();
            _throwYutResult = throwYut.ThrowYutResult();

            Console.WriteLine("던져서" + " " + "나온값" + ":" + _throwYutResult);


            for (int i = 0; i < _throwYutResult; i++)
            {
                checkeddirection = checkDirectionSelect.CheckDirection(testUnit, 1);

                testUnit = going.Directionsetting(testUnit, checkeddirection);

                Console.WriteLine(testUnit[0] + " " + testUnit[1] + " " +testUnit[2]);
            }

            return testUnit;
        }

    }
}

