using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        List<Unit> _소유한유닛정보 = new List<Unit>();
        int _진행턴;
        int _플레이어넘버;
        int _점수;
        bool _턴스킵여부;

        public void 플레이어생성하기(int 플레이어넘버)
        {
            // 플레이어 넘버 1~2 중 하나 지정
            // 유닛 1~4 만들기

        }

        public int 유닛선택하기()
        {
            //유닛 1~4에서 하나를 선택
            return 1;
        }

    }
}
