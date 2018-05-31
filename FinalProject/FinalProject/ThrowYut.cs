using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    class ThrowYut
    {
        String _positionTag;

        public int ThrowYutResult()
        {
            Random r = new Random();
            int result = r.Next(-1, 5);
            return result;
        }
    }
}

