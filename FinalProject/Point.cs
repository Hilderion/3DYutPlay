using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Point
    {
        List<int> location = new List<int>();
        List<Point> linkedPoints = new List<Point>();
        bool _isFilled;

        public abstract void Excute() { }


    }
}
