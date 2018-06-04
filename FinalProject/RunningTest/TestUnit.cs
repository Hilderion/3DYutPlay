using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.RunningTest
{
    class TestUnit : MapPoint.MapPoint
    {
        public List<double> TestBot()
        {
            setPosition(new List<double> { 0, 0, 0 });
            setDirection(1);
            return getPosition();
            getDirection();

        }

        public List<double> TestBot2()
        {
            setPosition(new List<double> { 0, 0, 0 });
            setDirection(1);
            return getPosition();
            getDirection();

        }

    }
}
