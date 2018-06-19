namespace FinalProject.Points
{
    class MountainPoint : Point
    {
        public MountainPoint(int id, params int[] nextIds) : base(id, nextIds)
        {
        }

        public override PointType Type => PointType.Mountain;

     

 
    }
}