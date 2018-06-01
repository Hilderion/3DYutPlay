using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class CheckDirectionSelect
    {
        int direction;
        List<int> first = new List<int> { 12, 0, 0 };
        List<int> second = new List<int> { 12, 0, 12 };
        List<int> third = new List<int> { 0, 0, 12 };
        List<int> well = new List<int> { 6, 0, 6 };

        SelectDirection selectDirection = new SelectDirection();

        public int CheckDirection(List<int> currentpositon)
        {
            if (currentpositon[0] == first[0] && currentpositon[1] == first[1] && currentpositon[2] == first[2])
            {
                direction = selectDirection.SelectDirect(1);
                return direction;

            }
            else if (currentpositon[0] == second[0] && currentpositon[1] == second[1] && currentpositon[2] == second[2])
            {
                direction = selectDirection.SelectDirect(2);
                return direction;

            }
            else if (currentpositon[0] == third[0] && currentpositon[1] == third[1] && currentpositon[2] == third[2])
            {
                direction = selectDirection.SelectDirect(3);
                return direction;

            }
            else
            {
                direction = selectDirection.SelectDirect(4);
                return direction;
            }

        }
    }
}
