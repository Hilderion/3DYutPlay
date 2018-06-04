using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class CornerPoint : MapPoint
    {
        int movepoint = 1;
        String cornerType;

        public CornerPoint()//각각의 모서리마다 개별로 지정(1,2,3번째+중앙)
        {
            int pointdirection;//유닛에게 전달할 디렉션 번호
            setPosition(new List<double> { 12, 0, 0 });
            setDirection(2);
            cornerType = "FirstCorner";
            pointdirection = getDirection();

        }

        public void CornerPoint2()
        {
            int pointdirection;
            setPosition(new List<double> { 12, 0, 12 });
            setDirection(3);
            cornerType = "SecondCorner";
            pointdirection = getDirection();
        }

        public void CornerPoint3()
        {
            int pointdirection;
            setPosition(new List<double> { 0, 0, 12 });
            setDirection(4);
            cornerType = "ThirdCorner";
            pointdirection = getDirection();
        }


    }
}
