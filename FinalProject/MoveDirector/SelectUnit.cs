using System;
using System.Collections.Generic;

namespace FinalProject.MoveDirector
{
    class SelectUnit
    {
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
