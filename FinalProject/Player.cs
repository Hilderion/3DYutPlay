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
        internal int _진행턴 { get; private set; }
        internal int _플레이어넘버 { get; private set; }
        internal int _점수 { get; private set; }
        internal bool _턴스킵여부 { get; private set; }

        public Player(int 플레이어넘버)
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
