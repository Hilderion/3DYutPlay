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
        }
        #endregion

        public void Initialize()
        {
        }

        public void InitializeForTest()
        {
        }
        
        private Dictionary<int, Point> _points = new Dictionary<int, Point>();

        public Point this[int pointId]
        {
            get { return _points[pointId]; }
        }

    }   
}
