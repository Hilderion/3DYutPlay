using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class DefaultPoint : MapPoint
    {
        //기본은 0, 몇개만 수치부여
        int change, temp;

        public DefaultPoint()
        {
            setPosition(new List<double> { 3, 0, 0 });
            setPointType("Default");
            setDirection(1);
            Random random = new Random();
            temp = random.Next(1, 6);
        }

        public int ChangeAttack()
        {
            if (temp % 2 == 0)
            {
                change = 1;
                return change;
            }
            else
            {
                change = -1;
                return change;
            }
        }

        public int ChangeDefence()
        {
            if (temp % 2 == 0)
            {
                change = 1;
                return change;
            }
            else
            {
                change = -1;
                return change;
            }
        }
    }
}
