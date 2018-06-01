using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class MoveUnity
    {
        List<int> Direction = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        //기본적인 이동방향 - 1 :  x만 증가, 2 :  z만 증가, 3 :  x만 감소, 4 : z만 감소
        //첫번째 코너 - 2(기본적인 경우), 5(산 위로) : x감소/y,z증가, 6(지하로) : x감소/z증가 
        //두번째 코너 - 3(기본적인 경우), 7(산 위로) : x,z감소 / y증가, 8(지하로) : x, z감소
        //세번째 코너 - 4(기본적인 경우), 9(산 위로) : x,y증가 / z감소, 10(지하로) : x증가/z감소
        //꼭대기 - 11(출발점으로) : x,y,z 감소, 12(세번째 코너로) : x,y감소 / z증가
        //우물 - 13(출발점으로) : x,z감소, 14(세번째 코너로) : x감소 / z증가

        public List<int> Directionsetting(List<int> currentposition, int direction)
        {
            List<int> destination = new List<int>();
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


            return destination;
        }
    }
}
