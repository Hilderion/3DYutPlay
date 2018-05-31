using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class CornerPoint : MapObject
    {
        int movePoint;
        int position, merit;
        
        public void Initial()
        {
            CornerPoint crossRoad = new CornerPoint();
            crossRoad.setmapType("CornerPoint");
            crossRoad.setTag("Corner");

            if (position == merit) //merit는 시작점에서 대각선에 있는 점
                movePoint = 1;
            
        }
    }
}
