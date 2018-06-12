using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Map
{
    abstract class Point
    {
        List<Point> MovablePoints = new List<Point>();
        Point PointPosition { get; set; }

        public abstract void Excute();
    }
}
