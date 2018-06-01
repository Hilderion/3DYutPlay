using System;
using FinalProject.GameDirector;

namespace FinalProject.MoveDirector
{
    class Move
    {
        String _positionTag;
        PointTypeChecker pointTypeChecker = new PointTypeChecker();
        SkipChecker skipChecker = new SkipChecker();

        ThrowYut throwYut = new ThrowYut();

        public void Moving(String _positionTag)
        {
            this._positionTag = _positionTag;
        }

        public void PointTypeCheck(String _positionTag, int input)
        {
            SelectUnit selectUnit = new SelectUnit();
            Boolean selectUnitResult = selectUnit.SelectUnitResult(input);

            if (_positionTag == "cornerPoint" || _positionTag == "topPoint")
            {
                SelectDirection(input);
                if (selectUnitResult == true)
                {
                    ThrowNMove();
                }
            }
            else if (pointTypeChecker.PointTypeCheck() == "Well")
            {
                skipChecker._turnSkip = true;
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
            int result = throwYut.ThrowYutResult();
            RealMove(result);
        }

        public void SelectDirection(int input)
        {
            //←, →, ↑ 각각의 방향키 입력 시 이동
        }

        public int RealMove(int result)
        {
            int movePoint = result;

            if (movePoint == 6) //빽도
            {
                //말의 이동
                Console.WriteLine("6이나옴!!!!");
                return movePoint;
                //TODO : movepoint에 실제 말의 이동 넣어주기. return붙은것들
            }
            while(movePoint != 0)
            {
                //말의 이동
                movePoint--;
            }

            return movePoint;
        }
    }
}
