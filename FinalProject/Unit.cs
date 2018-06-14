using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Unit
    {
        private int Attackpoint { get; set; }
        private int Defencepoint { get; set; }
        private int Extramovepoint { get; set; }

        public void Move(int movepoint) { }
        public void Battle(Unit unit) { }
        public void UnitLink(Unit unit) { }
        public void ChangeAttackPoint(int point) { }
        public void ChangeDefencePoint(int point) { }
        public int ChangeMovePoint(int point) { return Extramovepoint; }
        public void GoalUnit() { }
    }
}
