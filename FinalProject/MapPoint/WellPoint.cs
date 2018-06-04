using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class WellPoint : MapPoint
    {
        public WellPoint()
        {
            int pointdirection;//유닛에게 전달할 디렉션번호
            setPosition(new List<double> { 6, 0, 6 });
            setDirection(4);
            setPointType("Center");
            pointdirection = getDirection();
        }


    }
}
