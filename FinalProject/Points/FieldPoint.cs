namespace FinalProject.Points
{
    public class FieldPoint : Point
    {
        public FieldPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Field;

        public int Armor { get; internal set; }
        public int Weapon { get; internal set; }

     
    }
}