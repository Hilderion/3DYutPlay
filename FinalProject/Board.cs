using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Board
    {
        MountainPoint mountainPoint = new MountainPoint();
        FieldPoint fieldPoint = new FieldPoint();
        WellPoint wellPoint = new WellPoint();
        CornerPoint cornerPoint = new CornerPoint();

        List<Point> boardPoints = new List<Point>();

        public void CreateBoard() { }

        public void Excute() { }
    }
}
