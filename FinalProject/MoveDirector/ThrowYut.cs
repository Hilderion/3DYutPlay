using System;

namespace FinalProject.MoveDirector
{
    class ThrowYut
    {
        public int ThrowYutResult()
        {
            Random r = new Random();
            int result = r.Next(1, 6);
            return result;
        }

        public Boolean isThrowYutResult(int t)
        {
            return true;
        }
    }

}
