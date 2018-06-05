using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MoveDirector
{
    class NeedToMove
    {
        ThrowYut throwYut = new ThrowYut();
        Boolean throwYoutOrNot; 

        SelectUnit selectUnit = new SelectUnit();
        Boolean selectUnitOrNot;

      



        public void NeedToMoveResult(Boolean throwYutOrNot, Boolean selectUnitOrNot)
        {
            throwYoutOrNot = throwYut.isThrowYutResult(1);
            scanner input = new scanner();
            selectUnitOrNot = selectUnit.isSelectUnitResult(1);
            

            if (throwYoutOrNot && selectUnitOrNot)
            {
                Move move = new Move();
            }
            else
            {
                SelectUnit selectUnit = new SelectUnit();
                ThrowYut throwYut = new ThrowYut();
            }
        }




    }
}
