using System;

namespace FinalProject.MoveDirector
{
    class ThrowYut
    {
        public Boolean isThrowCheck = false;       

        public void Throwcheck()
        {
            isThrowCheck = true;
        }

        public void resetThrowCheck()
        {
            isThrowCheck = false;
        }

        public int ThrowYutResult()
        {
            Random r = new Random();
            int result = r.Next(1, 6);
            return result;
        }
    }

}
