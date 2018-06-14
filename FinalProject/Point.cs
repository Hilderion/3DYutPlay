using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Point
    {
        List<Point> 연결된포인트 = new List<Point>();
        private int 포인트넘버 { get; set; }
        bool _칸채워짐여부;

        public abstract void 실행하기();
    }

    class FieldPoint : Point
    {
        int _유닛스탯증감포인트;
        public override void 실행하기()
        {
            //changepoint에 값을 부여하고 TransferChangePoint실행
        }

        public int 유닛스탯증감시키기()
        {
            return _유닛스탯증감포인트;
        }
    }

    class MountainPoint : Point
    {
        public override void 실행하기()
        {
            //산적, 유닛의 공격력이 1보다 낮으면 뒤로 한칸 물러남
        }
    }

    class WellPoint : Point
    {
        public override void 실행하기()
        {
            //플레이어의 턴을 한턴 스킵
        }
    }

    class CornerPoint : Point
    {
        public override void 실행하기()
        {
            //방향을 선택
        }
    }
}
