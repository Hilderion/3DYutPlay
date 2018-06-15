namespace FinalProject.Points
{
    class FieldPoint : Point
    {
        int _능력치변화케이스;

        public override PointType Type => PointType.Field;

        public override void 실행하기()
        {
            //변화할 케이스를 랜덤으로 정한다 (1 : 공격력증가, 2:공격력감소... )
            _능력치변화케이스 = 1;
        }

        private int 변화할케이스를전송하기()
        {
            //'실행하기'에서 결정된 케이스를 유닛에게 전송한다
            return _능력치변화케이스;
        }

    }
}