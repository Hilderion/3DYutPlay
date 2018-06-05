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
        int _checkeddirection=1;

        public void ActualMove(List<double> testUnit)
        {

            ThrowYut throwYut = new ThrowYut();
            _throwYutResult = throwYut.ThrowYutResult();

         
            Console.WriteLine("던져서" + " " + "나온값" + ":" + _throwYutResult);


            for (int i = 0; i < _throwYutResult; i++)
            {
                _checkeddirection = checkDirectionSelect.CheckDirection(testUnit, _checkeddirection);

                testUnit = going.Directionsetting(testUnit, _checkeddirection);

                Console.WriteLine(testUnit[0] + " " + testUnit[1] + " " +testUnit[2]);
            }

        }

    }
}

