using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    public class Move
    {
        String _positionTag;

        public Move(String _positionTag)
        {
            this._positionTag = _positionTag;
        }



        public void PointTypeCheck(String _positionTag, int input)
        {


            SelectUnit selectUnit = new SelectUnit();
            Boolean selectUnitResult = selectUnit.SelectUnitResult(input);

            if (_positionTag == "cornerpoint" || _positionTag == "topPoint")
            {
                SelectDirection(input);
                if (selectUnitResult == true)
                {
                    ThrowNMove();
                }
            }
            else if (_positionTag == "wellPoint")
            {
                Skip();
            }
            else
            {
                if (selectUnitResult == true)
                {
                    ThrowNMove();
                }
            }
        }

        public void ThrowNMove()
        {
            ThrowYut throwYut = new ThrowYut();
            int result = throwYut.ThrowYutResult();
            RealMove(result);
        }

        public void SelectDirection(int input)
        {
            //←, →, ↑ 각각의 방향키 입력 시 이동
        }

        public void Skip()
        {

            //턴스킵

        }

        public void RealMove(int result)
        {


            ThrowYut throwYut = new ThrowYut();
            int movePoint = throwYut.ThrowYutResult();

            if (movePoint == 6) //빽도
            {
                //말의 이동
            }
            else
            {
                while (movePoint != 0)
                {
                    //말의 이동
                    movePoint--;
                }

            }



        }
    }
}






