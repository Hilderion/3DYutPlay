using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MoveDirector
{
    class NeedToMove
    {
        
              
        public bool NeedToMoveResult(Unit selectedUnit, ThrowYut throwCheck)
        {
            
            
            if (selectedUnit.isSelected==true && throwCheck.isThrowCheck==true)
            {
                Console.WriteLine("Run game");
                return true;
            }
            else
            {
                Console.WriteLine("Please check selected unit or Yut throw");
                return false;
            }
        }




    }
}
