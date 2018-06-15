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
                    case HorseType.Offensive:
                        return new Horse(player, 1,0,0);
                    case HorseType.Heavy:
                        return new Horse(player, 1,1,-1);
                    case HorseType.Defensive:
                        return new Horse(player, 0,1,0);
                    case HorseType.Speedy:
                        return new Horse(player, 1,-1,1);
                    default:
                        throw new Exception();
            }
        }
        
        private Horse(Player player, int weapon, int armor, int speed)
        {
            Weapon = weapon;
            Armor = armor;
            Speed = speed;
            Player = player;
            Point = Board.Instance.StartingPoint;
            
            _carrierees = new List<Horse>();
        }

        public int Weapon { get; internal set; }
        public int Armor { get; internal set; }
        public int Speed { get; internal set; }

        public Player Player { get;}

        public bool Finished { get; internal set; }
        
        public bool Carried { get; internal set; }

        public Point Point { get; internal set; }
        
        /// <summary>
        /// 업힌 말들. (자신은 포함하지 않음)
        /// </summary>
        private List<Horse> _carrierees = new List<Horse>();

        /// <summary>
        /// 자신 + 업힌 말들
        /// </summary>
        public List<Horse> CarriereesAndSelf
        {
            get
            {
                var list = _carrierees.ToList();
                list.Add(this);
                return list;
            }
        }
        
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
            get { return CalculateMaxValue(x => x.Weapon); }
        }
        
        public int MaxArmor
        {
            get { return CalculateMaxValue(x => x.Armor); }
        }
        
        public int MinSpeed
        {
            get
            {
                int minOfCarrierees = _carrierees.Min(x => x.Speed);
                return Math.Min(minOfCarrierees, Speed);
            }
        }
        #endregion
    }
    
    public enum HorseType
    {
        Offensive,
        Heavy,
        Defensive,
        Speedy
    }
}