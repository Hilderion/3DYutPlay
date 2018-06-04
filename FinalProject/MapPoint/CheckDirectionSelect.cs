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
        List<double> first = new List<double> { 12, 0, 0 };
        List<double> second = new List<double> { 12, 0, 12 };
        List<double> third = new List<double> { 0, 0, 12 };
        List<double> well = new List<double> { 6, 0, 6 };

        SelectDirection selectDirection = new SelectDirection();

        public int CheckDirection(List<double> currentpositon, int savedirection)
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
            else if (currentpositon[0] == well[0] && currentpositon[1] == well[1] && currentpositon[2] == well[2])
            {
                direction = selectDirection.SelectDirect(4);
                return direction;
            }
            else
                return savedirection;

        }
    }
}
