using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class MountainPoint : MapPoint
    {
        int thief = 1;

        public MountainPoint()
        {
            setPosition(new List<double> { 3, 3, 3 });
            setPointType("Mountain");
            setDirection(6);
        }

    }
}
