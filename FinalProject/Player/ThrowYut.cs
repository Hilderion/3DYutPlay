using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Player
{
    class ThrowYut
    {
        public Boolean isThrowCheck = false;

        public void isThrowToTrue(bool isThrow)
        {
            isThrow = true;
        }

        public void isThrowToFalse(bool isThrow)
        {
            isThrow = false;
        }

        public int ThrowYutResult()
        {
            Random r = new Random();
            int movePoint = r.Next(1, 6);
            return movePoint;
        }
    }
}
