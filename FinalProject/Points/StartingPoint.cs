namespace FinalProject.Points
{
    public class StartingPoint : Point
    {
        public StartingPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Starting;
        
    
    }
}