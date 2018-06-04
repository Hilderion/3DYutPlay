using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class Move
    {
        //기본적인 이동방향 - 1 :  x만 증가, 2 :  z만 증가, 3 :  x만 감소, 4 : z만 감소
        //첫번째 코너 - 2(기본적인 경우), 5(가운데로) : x감소/z증가 
        //두번째 코너 - 3(기본적인 경우), 6(가운데로) : x, z감소
        //세번째 코너 - 4(기본적인 경우), 7(가운데로) : x증가/z감소
        //우물 - 8(출발점으로) : x,z감소, 9(세번째 코너로) : x감소 / z증가

        public List<double> Directionsetting(List<double> currentposition, int direction)
        {
            List<double> destination = new List<double>();

            if (direction == 1)
            {
                currentposition[0] += 3;
                destination = currentposition;
                return destination;

            }
            else if (direction == 2)
            {
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 3)
            {
                currentposition[0] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 4)
            {
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 5)
            {
                currentposition[0] -= 3;
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 6)
            {
                currentposition[0] -= 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 7)
            {
                currentposition[0] += 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 8)
            {
                currentposition[0] -= 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else
            {
                currentposition[0] -= 3;
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }

        }
    }
}
