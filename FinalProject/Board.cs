using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Points;

namespace FinalProject
{
    public class Board
    {
        #region singleton
        private static Board _instance;
        
        public static Board Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Board();
                
                return _instance;
            }
        }
        
        private Board()
        {
            #region points
            AddPoint(0, 1);
            AddPoint(1, 2);
            AddPoint(2, 3);
            AddPoint(3, 4);
            AddPoint(4, 5);
            AddPoint(5, 8,9, 30);
            AddPoint(6, 0);
            AddPoint(7, 0);
            AddPoint(8, 12);
            AddPoint(9, 13);
            AddPoint(10, 6);
            AddPoint(11, 7);
            AddPoint(12, 14);
            AddPoint(13, 18);
            AddPoint(14, 11,16);
            AddPoint(15, 10);
            AddPoint(16, 20);
            AddPoint(17, 14);
            AddPoint(18, 22);
            AddPoint(19, 15);
            AddPoint(20, 23);
            AddPoint(21, 17);
            AddPoint(22, 28);
            AddPoint(23, 19);
            AddPoint(24, 23);
            AddPoint(25, 24);
            AddPoint(26, 25);
            AddPoint(27, 26);
            AddPoint(28, 21,27);
            AddPoint(29, 0);
            AddPoint(30, 31);
            AddPoint(31, 29, 32);
            AddPoint(32, 23);
            AddPoint(33, 31);

            InitializeFieldPoints();
            #endregion
        }

        private void InitializeFieldPoints()
        {
            var fieldPoints = _points.Where(x => x.Type == PointType.Field).Cast<FieldPoint>().ToList();
            
            Random random = new Random();
            foreach (var fieldPoint in fieldPoints)
            {
                fieldPoint.Weapon = random.Next(3) - 1;
                fieldPoint.Armor = random.Next(3) - 1;
            }
        }

        private int[] _mountainIds = { 29,30,32,33};
        
        private int[] _cornerIds = {5,14,23,28,31};
        
        private void AddPoint(int id, params int[] nextIds)
        {
            Point point = null;
            
            if (_cornerIds.Contains(id))
                point = new CornerPoint(id, nextIds);
            else if (_mountainIds.Contains(id))
                point = new MountainPoint(id, nextIds);
            else if (id == 0)
                point = new StartingPoint(id, nextIds);
            else
                point = new FieldPoint(id, nextIds);
            
            _points.Add(point);
        }
        #endregion

        public void Initialize()
        {
            Board.Instance.InitializeFieldPoints();
        }

        public void InitializeForTest()
        {
        }

        private List<Point> _points = new List<Point>();

        public Point this[int pointId]
        {
            get { return _points[pointId]; }
        }

        public List<Player> Players { get; }

        public Point StartingPoint => _points[0];
    }   
}
