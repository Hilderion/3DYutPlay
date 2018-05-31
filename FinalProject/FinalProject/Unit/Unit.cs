﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Unit
    {
        public int _Player { get; protected set; } //소유 플레이어
        public UnitTag unitTag { get; protected set; } //태그
        
        public int _Attack { get; protected set; } //공격력
        public int _Defense { get; protected set; } //방어력
        public int _Speed { get; protected set; } //이동속도

        public bool isGoaled; //골인체크

        public int[] FieldLocation { get; set; }

        public List<int[]> LocationHistory;
        int currentPosition;

        public Unit(int Player, UnitTag Tag)
        {
            _Player = Player;
            isGoaled = false;
            FieldLocation = new int[3] { 0, 0, 0 };
            unitTag = Tag;

            _Attack = 0; _Defense = 0; _Speed = 0;
            switch (Tag)
            {
                case UnitTag.Knight:
                    _Attack = 1;
                    break;
                case UnitTag.HeavySoldier:
                    _Attack = 1; _Defense = 1; _Speed = -1;
                    break;
                case UnitTag.Guard:
                    _Defense = 1;
                    break;
                case UnitTag.Scout:
                    _Attack = 1; _Defense = -1; _Speed = 1;
                    break;
            }
        }

        public void AttackAdjust(int Amount)
        {
            _Attack += Amount;
        }

        public void DefenseAdjust(int Amount)
        {
            _Defense += Amount;
        }

        public void SpeedAdjust(int Amount)
        {
            _Speed += Amount;
        }
    }
    public enum UnitTag { Knight, HeavySoldier, Guard, Scout }
}