namespace FinalProject.Points
{
    class CornerPoint : Point
    {
        public CornerPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Corner;

     

        public int 선택한포인트반환()
        {
            // 코너포인트에서 선택한 진행방향포인트를 반환함
            return 0;
        }
    }
}
