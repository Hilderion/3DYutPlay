namespace FinalProject.Points
{
    class CornerPoint : Point
    {
        public override PointType Type => PointType.Corner;

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
