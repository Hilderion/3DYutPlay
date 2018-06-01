using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class Start : MapPoint
    {
        private void Initial()
        {
            setPointType("Start");
            setPosition(new List<int> { 0, 0, 0 });
            setDirection(1);
        }
    }
}
