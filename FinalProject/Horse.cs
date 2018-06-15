using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject.Points;

namespace FinalProject
{
    public class Horse
    {
        public static Horse Create(Player player, HorseType horseType)
        {
            switch (horseType)
            {
                    case HorseType.A:
                        return new Horse(player, 1,0,0);
                    case HorseType.B:
                        return new Horse(player, 1,1,-1);
                    case HorseType.C:
                        return new Horse(player, 0,1,0);
                    case HorseType.D:
                        return new Horse(player, 1,-1,1);
                    default:
                        throw new Exception();
            }
        }
        
        private Horse(Player player, int weapon, int armor, int speed)
        {
            _weapon = weapon;
            _armor = armor;
            _speed = speed;
            Player = player;
            
            _carrierees = new List<Horse>();
        }

        private int _weapon;
        private int _armor;
        private int _speed;

        public Player Player { get;}

        public bool Finished { get; internal set; }
        
        public bool Carried { get; internal set; }
        
        /// <summary>
        /// 업힌 말들. (자신은 포함하지 않음)
        /// </summary>
        private List<Horse> _carrierees = new List<Horse>();
        
        private Stack<Point> _visitedPoints = new Stack<Point>();

        public void VisitPoint(Point point)
        {
        }

        public void Carry(Horse carrieree)
        {
            _carrierees.Add(carrieree);
            carrieree.Carried = true;
        }

        public void Decarry()
        {
            _carrierees.ForEach(x => x.Carried = false);
            _carrierees.Clear();
        }

        #region 최대 공격력/방어력, 최소 이동력
        private int CalculateMaxValue(Func<Horse, int> func)
        {
            int maxOfCarrierees = _carrierees.Max(func);
            return Math.Max(maxOfCarrierees, func(this));
        }
        
        public int MaxWeapon
        {
            get { return CalculateMaxValue(x => x._weapon); }
        }
        
        public int MaxArmor
        {
            get { return CalculateMaxValue(x => x._armor); }
        }
        
        public int MinSpeed
        {
            get
            {
                int minOfCarrierees = _carrierees.Min(x => x._speed);
                return Math.Min(minOfCarrierees, _speed);
            }
        }
        #endregion
    }
    
    public enum HorseType
    {
        A,
        B,
        C,
        D
    }
}