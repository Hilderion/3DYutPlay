using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Unit
    {
        internal int 공격력 { get; private set; }
        internal int 방어력 { get; private set; }
        internal int 이동력 { get; private set; }
        internal bool 도착여부 { get; private set; }
        internal int 현재위치 { get; private set; }

        List<Point> _지나온포인트기록;
        List<Unit> _합쳐진유닛들;

        public Unit(int attack, int defense, int speed)
        //공격력, 방어력, 추가이동력 초기값 요구
        {
            공격력 = attack;
            방어력 = defense;
            이동력 = speed;

            _합쳐진유닛들 = new List<Unit> { this };
        }

        public void 이동하기(int 윷값, int 다음진행할포인트고유번호)

        {
            //윷 던지기에서 '윷값'을 받아서 그 숫자만큼 이동한다
            //'다음진행할포인트고유번호'로 이동한다 (1~25중 )
        }

        public void 전투하기(Unit 방어유닛)
        {
            //방어유닛을 대상으로 전투한다

        }


        public void 유닛업기(Unit 업힐유닛)
        {
            // 지금 유닛에 '업힐유닛'을 받아서 업는다
        }


        public void 능력치변경(int 능력치변화케이스)
        {
            //능력치변화케이스에 들어온 값에 따라 case 구문으로 받는다.
            // 1: 공격력증가, 2: 공격력감소, 3:방어력증가, 4:방어력감소
            switch (능력치변화케이스)
            {
                case 1:
                    //공격력증가
                    break;
                case 2:
                    //공격력감소
                    break;
                case 3:
                    //방어력증가
                    break;
                case 4:
                    //방어력감소
                    break;
            }

        }

        public void 유닛도착처리하기()
        {
            도착여부 = true;
        }
    }
}
