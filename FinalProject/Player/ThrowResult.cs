using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Player
{
    class ThrowResult
    {
        ThrowYut throwYut = new ThrowYut();
        int movePoint;

        public int AfterThrow()
        {
            movePoint = throwYut.ThrowYutResult();
            return movePoint;
        }
    }
}
