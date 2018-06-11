using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class GetAndSetUnit
    {
        public int SetUnit()
        {
            String GetUnit;
            int SelectUnit;

            Console.WriteLine("================");
            Console.WriteLine("1~4중유닛선택");
            Console.WriteLine("================");

            GetUnit = Console.ReadLine();
            SelectUnit = Convert.ToInt32(GetUnit);
            Console.WriteLine(SelectUnit + "번 유닛 선택됨");
            Console.WriteLine("-------------");

            return SelectUnit;

        }

        public void isSelectUnitResult(Unit selectedUnit)
        {
            selectedUnit.isSelected = true;
        }

        public void unSelectUnit(Unit selectedUnit)
        {
            selectedUnit.isSelected = false;
        }

    }
}
