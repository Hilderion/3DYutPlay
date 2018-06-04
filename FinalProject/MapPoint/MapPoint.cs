using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class MapPoint
    {
        internal List<double> position; //좌표를 저장, 나중에 벡터 사용해서 도출
        int direction;//칸마다 디렉션을 저장, 이 디렉션을 move메서드에서 사용하여 디렉션 결정
        String mapPointType; //디폴트, 산, 코너, 우물, 출발점

        public List<double> getPosition()
        {
            return position;
        }

        public void setPosition(List<double> pointposition)
        {
            position = pointposition;
        }

        public void setDirection(int setteddirection)
        {
            direction = setteddirection;
        }

        public int getDirection()
        {
            return direction;
        }

        public void setPointType(String pointtype)
        {
            mapPointType = pointtype;
        }

        public String getPointType()
        {
            return mapPointType;
        }




    }
}
