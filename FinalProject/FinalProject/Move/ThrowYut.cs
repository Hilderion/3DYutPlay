using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    public class ThrowYut
    {
        public int ThrowYutResult()
        {
            Random r = new Random();
            int result = r.Next(1, 6);
            return result;
        }
    }
}



