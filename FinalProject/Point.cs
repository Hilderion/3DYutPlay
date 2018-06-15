using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Point
    {
        List<Point> _연결된포인트고유번호 = new List<Point>();
        internal int _포인트고유번호 { get; private set; }
        internal bool _칸채워짐여부 { get; private set; }
        
        public abstract void 실행하기();
    }

    class FieldPoint : Point
    {
        int 스탯변화케이스;
        
        
        public override void 실행하기()
        {
            //변화할 케이스를 랜덤으로 정한다 (1 : 공격력증가, 2:공격력감소... )
        }

        private int 변화할케이스를전송하기()
        {
            //'실행하기'에서 결정된 케이스를 유닛에게 전송한다

            return 0;
        }
    }

    class MountainPoint : Point
    {
        public override void 실행하기()
        {
            //산적, 유닛의 공격력이 1(산적의 공격력)보다 낮으면 뒤로 한칸 이동함(연결포인트의 이전 포인트로 이동한다)
        }
    }

    class WellPoint : Point
    {
        public override void 실행하기()
        {
            //플레이어의 턴을 한턴 스킵
            //플레이어의 '턴스킵여부'를 true로 바꾼다
        }
    }

    class CornerPoint : Point
    {
        public override void 실행하기()
        {
            //연결된 포인트에서 진행방향을 하나 선택
        }

        public int 선택한포인트반환()
        {
            // 코너포인트에서 선택한 진행방향포인트를 반환함
            return 0;
        }
    }
}
