namespace FinalProject.Points
{
    class MountainPoint : Point
    {
        public MountainPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Mountain;

        public override void Execute(Horse horse)
        {
            //산적, 유닛의 공격력이 1(산적의 공격력)보다 낮으면 뒤로 한칸 이동함(연결포인트의 이전 포인트로 이동한다)
        }

 
    }
}