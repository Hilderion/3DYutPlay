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
        
        public int _checkeddirection;

        public void ActualMove(Unit movingUnit, int result, int unitdirection)
        {
            
            for (int i = 0; i < result; i++)
            {
                _checkeddirection = checkDirectionSelect.CheckDirection(movingUnit.UnitPosition, unitdirection);
                
                movingUnit.UnitPosition = move.Directionsetting(movingUnit.UnitPosition, _checkeddirection);
                unitdirection = _checkeddirection;

                Console.WriteLine(movingUnit.UnitPosition[0] + " " + movingUnit.UnitPosition[1] + " " + movingUnit.UnitPosition[2]);
            }

            

        }

    }
}

