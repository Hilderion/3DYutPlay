using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.RunningTest
{
    class TestUnit : MapPoint.MapPoint
    {
        public List<int> TestBot()
        {
            setPosition(new List<int> { 0, 0, 0 });
            setDirection(1);
            return getPosition();

        }

    }
}
