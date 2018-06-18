using System;
using System.Collections.Generic;
using FinalProject.Points;

namespace FinalProject
{
    public class Game
    {
        #region singleton
        private static Game _instance;

        public static Game Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Game();

                return _instance;
            }
        }

        private Game()
        {
            Players = new List<Player>();
            Players.Add(new Player(0));
            Players.Add(new Player(1));

            ActivePlayer = Players[0];
        }
        #endregion

        public List<Player> Players { get; private set; }

        public Player ActivePlayer { get; private set; }

        public void Run()
        {
            OnStarted();
            OnHorseSelecting(HorseType.Defensive);
        }

        public void TurnToNextPlayer()
        {
            int nextPlayerId = (ActivePlayer.Id + 1) % Players.Count;

            ActivePlayer = Players[nextPlayerId];
        }

        public void MoveHorse(HorseType horseType, int dice)
        {
            Horse horse = ActivePlayer[horseType];

            Point currentPoint = horse.Point;
            
            while (dice > 0)
            {
                currentPoint = currentPoint.Next;
                dice--;
            }
            
            horse.Point = currentPoint;

            if (horse.Point.Type == PointType.Field)
            {
                VisitField(currentPoint, horse);
            }
            else if (horse.Point.Type == PointType.Mountain)
            {
                VisitMountain(currentPoint, horse);
            }
        }

//        public int MoveHorse(HorseType horseType, int dice, out Point point)
//        {
//            Horse horse = ActivePlayer.Horses[(int) horseType];
//            Point next = horse.Point;
//
//            do
//            {
//                next = next.Next;
//                dice--;
//                
////                if ()
//
//                VisitField(next, horse);
//
//                VisitMountain(next);
//            } while (dice == 0 || next.Type == PointType.Corner);
//
////            OnHorseMoved(nextPoint);
//            throw new Exception();
//        }

        private void VisitField(Point point, Horse horse)
        {
            FieldPoint field = point as FieldPoint;
            if (field == null)
                return;
            
            foreach (var h in horse.CarriereesAndSelf)
            {
                h.Weapon += field.Weapon;
                h.Armor += field.Armor;
            }

            OnFieldPointVisited(horse, field);
        }

        private void VisitMountain(Point point, Horse horse)
        {
            MountainPoint mountain = point as MountainPoint;
            if (mountain == null)
                return;

            if (horse.MaxWeapon > 1)
            {
                // 승리
            }
            else
            {
                // 패배
            }
        }

        #region FieldPointVisited event things for C# 3.0
        public event EventHandler<FieldPointVisitedEventArgs> FieldPointVisited;

        protected virtual void OnFieldPointVisited(FieldPointVisitedEventArgs e)
        {
            if (FieldPointVisited != null)
                FieldPointVisited(this, e);
        }

        private FieldPointVisitedEventArgs OnFieldPointVisited(Horse horse  , FieldPoint fieldPoint )
        {
            FieldPointVisitedEventArgs args = new FieldPointVisitedEventArgs(horse  , fieldPoint );
            OnFieldPointVisited(args);

            return args;
        }

        private FieldPointVisitedEventArgs OnFieldPointVisitedForOut()
        {
            FieldPointVisitedEventArgs args = new FieldPointVisitedEventArgs();
            OnFieldPointVisited(args);

            return args;
        }

        public class FieldPointVisitedEventArgs : EventArgs
        {
            public Horse Horse { get; set;}  
            public FieldPoint FieldPoint { get; set;} 

            public FieldPointVisitedEventArgs()
            {
            }
	
            public FieldPointVisitedEventArgs(Horse horse  , FieldPoint fieldPoint )
            {
                Horse = horse;  
                FieldPoint = fieldPoint; 
            }
        }
        #endregion
        #region HorseMoved event things for C# 3.0
        public event EventHandler<HorseMovedEventArgs> HorseMoved;

        protected virtual void OnHorseMoved(HorseMovedEventArgs e)
        {
            if (HorseMoved != null)
                HorseMoved(this, e);
        }

        private HorseMovedEventArgs OnHorseMoved(Point point)
        {
            HorseMovedEventArgs args = new HorseMovedEventArgs(point);
            OnHorseMoved(args);

            return args;
        }

        private HorseMovedEventArgs OnHorseMovedForOut()
        {
            HorseMovedEventArgs args = new HorseMovedEventArgs();
            OnHorseMoved(args);

            return args;
        }

        public class HorseMovedEventArgs : EventArgs
        {
            public Point Point { get; set; }

            public HorseMovedEventArgs()
            {
            }

            public HorseMovedEventArgs(Point point)
            {
                Point = point;
            }
        }
        #endregion

        #region Started event things for C# 3.0
        public event EventHandler<StartedEventArgs> Started;

        protected virtual void OnStarted(StartedEventArgs e)
        {
            if (Started != null)
                Started(this, e);
        }

        private StartedEventArgs OnStarted()
        {
            StartedEventArgs args = new StartedEventArgs();
            OnStarted(args);

            return args;
        }

/*private StartedEventArgs OnStartedForOut()
{
	StartedEventArgs args = new StartedEventArgs();
    OnStarted(args);

    return args;
}*/

        public class StartedEventArgs : EventArgs
        {
            /*public StartedEventArgs()
            {
            }
            
            public StartedEventArgs()
            {
                
            }*/
        }
        #endregion

        #region HorseSelecting event things for C# 3.0
        public event EventHandler<HorseSelectingEventArgs> HorseSelecting;

        protected virtual void OnHorseSelecting(HorseSelectingEventArgs e)
        {
            if (HorseSelecting != null)
                HorseSelecting(this, e);
        }

        private HorseSelectingEventArgs OnHorseSelecting(HorseType horseType)
        {
            HorseSelectingEventArgs args = new HorseSelectingEventArgs(horseType);
            OnHorseSelecting(args);

            return args;
        }

        private HorseSelectingEventArgs OnHorseSelectingForOut()
        {
            HorseSelectingEventArgs args = new HorseSelectingEventArgs();
            OnHorseSelecting(args);

            return args;
        }

        public class HorseSelectingEventArgs : EventArgs
        {
            public HorseType HorseType { get; set; }

            public HorseSelectingEventArgs()
            {
            }

            public HorseSelectingEventArgs(HorseType horseType)
            {
                HorseType = horseType;
            }
        }
        #endregion
    }
}