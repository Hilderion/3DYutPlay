namespace FinalProject.Points
{
    public abstract class Point
    {
        public Point(int id, params int[] nextIds)
        {
            Id = id;
            NextIds = nextIds;
        }
        
        public int[] NextIds { get; private set; }

        public Point Next
        {
            get
            {
                return Board.Instance[NextIds[0]];
                
            }
        }

        public Point Select(int direction)
        {
            return Board.Instance[NextIds[direction]];
            
        }

        public int Id { get; private set; }

        public abstract PointType Type { get; }

        
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}