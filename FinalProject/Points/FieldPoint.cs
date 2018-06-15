namespace FinalProject.Points
{
    class FieldPoint : Point
    {
        public FieldPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Field;

        public int Armor { get; internal set; }
        public int Weapon { get; internal set; }

        public override void Execute()
        {
            //변화할 케이스를 랜덤으로 정한다 (1 : 공격력증가, 2:공격력감소... )
        }
    }
}