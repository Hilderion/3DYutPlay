using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class GetAndSetUnit
    {
        public int GetSetUnit(int selectUnit)
        {
            String GetUnit;
            int SetUnit;

            Console.WriteLine("================");
            Console.WriteLine("1-4중유닛선택");
            Console.WriteLine("================");
            GetUnit = Console.ReadLine();
            SetUnit = Convert.ToInt32(GetUnit);
            return SetUnit;

        }

    }
}
