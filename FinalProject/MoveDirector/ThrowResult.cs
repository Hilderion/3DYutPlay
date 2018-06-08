using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MoveDirector
{
    class ThrowResult
    {
        ThrowYut throwYut = new ThrowYut();
        Random rand = new Random();
        int result;

        public int AfterThrow()
        {
            result = throwYut.ThrowYutResult();
            return result;
        }
    }
}
