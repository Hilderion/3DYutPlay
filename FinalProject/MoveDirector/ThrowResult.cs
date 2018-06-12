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
        int _result;

        public int AfterThrow()
        {
            _result = throwYut.ThrowYutResult();
            return _result;
        }
    }
}
