using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        public List<Unit> 유닛정보 = new List<Unit>();
        int _진행턴;
        int _플레이어넘버;
        int _점수;
        bool _턴스킵여부;

        public void 플레이어생성하기(int 플레이어넘버) { }

        public void 유닛생성하기() { }

        public int 유닛선택하기()
        {
            //1~4 유닛 사이에서 하나를 선택
            return 1;
        }



    }
}
