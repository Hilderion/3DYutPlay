namespace FinalProject.Points
{
    public abstract class Point
    {
        protected Point(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public abstract PointType Type { get; }

        public abstract void 실행하기();
    }
}