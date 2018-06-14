using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Point
    {
        
        List<Point> linkedPoints = new List<Point>();
        private int PointNumber { get; set; }
        bool _isFilled;

        public abstract void Excute();

        
        


    }

    class FieldPoint : Point
    {
        int _changepoint;
        public override void Excute()
        {
            //changepoint에 값을 부여하고 TransferChangePoint실행
        }

        public int TransferChangePoint()
        {
            return _changepoint;
        }
    }

    class MountainPoint : Point
    {
        public override void Excute()
        {
            //산적, 유닛의 공격력이 1보다 낮으면 뒤로 한칸 물러남
        }
    }

    class WellPoint : Point
    {
        public override void Excute()
        {
            //플레이어의 턴을 한턴 스킵
        }
    }

    class CornerPoint : Point
    {
        public override void Excute()
        {
            //방향을 선택
        }
    }
}
