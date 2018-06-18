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
                        return new Horse(player, (int) horseType, 1,0,0);
                    case HorseType.Heavy:
                        return new Horse(player, (int) horseType, 1,1,-1);
                    case HorseType.Defensive:
                        return new Horse(player, (int) horseType, 0,1,0);
                    case HorseType.Speedy:
                        return new Horse(player, (int) horseType, 1,-1,1);
                    default:
                        throw new Exception();
            }
        }
        
        private Horse(Player player, int id, int weapon, int armor, int speed)
        {
            Id = id;
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

        public int Id { get; private  set; }

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

        public void SaveVisitPoint(Point point)
        {
            _visitedPoints.Push(point);
        }

        public void Carry(Horse carrieree)
        {
            _carrierees.Add(carrieree);
            carrieree.Carried = true;
        }

        public void Decarry()
        {
//            _carrierees.ForEach(x => x.Carried = false);
            foreach (var carrieree in _carrierees)
                carrieree.Carried = false;
            _carrierees.Clear();
        }

        #region 최대 공격력/방어력, 최소 이동력
        public int MaxWeapon
        {
            get { return CarriereesAndSelf.Max(x => x.Weapon); }
        }
        
        public int MaxArmor
        {
            get
            {
                return CarriereesAndSelf.Max(x => x.Armor);
            }
        }
        
        public int MinSpeed
        {
            get { return CarriereesAndSelf.Min(x => x.Speed); }
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