using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    class ThrowYut
    {
        String _positionTag;

        public ThrowYut(String _positionTag)
        {
            this._positionTag = _positionTag;
        }

        public int ThrowYut()
        {
            Random r = new Random();
            int result = r.Next(-1, 5);
            return result;
        }


        public void CheckCurrentPosition()
        {

            if (_positionTag == "CornerPoint")
            {
                SelectDirection();
            }
            else if (_positionTag == "WellPoint")
            {
                Skip();
            }
            else
            {
                int result = ThrowYut();
                Move(result);
            }


        }

        public void SelectDirection()
        {
            //←, →, ↑ 각각의 방향키 입력 시 이동
        }

        public void Skip()
        {

            //턴스킵

        }

        public int Move(int result)
        {
            int totalMove = result;


            if (result == 4) //윷
            {
                Skip();
                ThrowYut();

            }
            else if (result == 5) //모
            {
                Skip();
                ThrowYut();
            }

            return totalMove;

        }


        public Boolean SelectUnit(int selectUnit)
        {
            //유닛을 선택했는지 체크
            return false;
        }
    }
}



