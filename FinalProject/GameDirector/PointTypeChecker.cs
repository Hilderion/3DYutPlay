using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class PointTypeChecker
        
    {
        MapPoint.MapPoint mapPoint = new MapPoint.MapPoint();


        public string PointTypeCheck()
        {
            if (mapPoint.getPointType() == "Mountain")
            {
                return "Mountain";
            }

            // TODO: under가 없다.
            else if (mapPoint.getPointType() == "Under")
            {
                return "UnderGround";
            }
            
            else if (mapPoint.getPointType() == "Center")
            {
                return "Center";
            }

            else if (mapPoint.getPointType() == "Bandit")
            {
                return "Bandit";
            }

            return "Default";
        }
        
    }
}

