using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Unit
    {
        private int Attackpoint { get; set; }
        private int Defencepoint { get; set; }
        private int Extramovepoint { get; set; }
        private bool isGoaled = false;
        public int[] Location = new int[3];
        private int[] FormalLocation = new int[3];
        public List<Unit> units;

        public Unit(int attack, int Defence, int ExMove)
        {
            Attackpoint = attack;
            Defencepoint = Defence;
            Extramovepoint = ExMove;

            units = new List<Unit>();
            units.Add(this);
        }

        public void Move(int yut)
        {
            if (yut == 6)
            {

            }
        }
        public void Battle(Unit defence) //이 메소드의 주체가 공격측, 매개변수 defense가 방어측
        {
            if (units.Max(x => x.Attackpoint) > defence.units.Max(x => x.Defencepoint))
            {
                foreach (Unit dead in defence.units)
                {
                    dead.Location = new int[3] { 0, 0, 0 };
                    dead.FormalLocation = new int[3] { 0, 0, 0 };
                }
            }
            else
            {
                Move(6);
            }
        }

        public void UnitLink(Unit unit)
        {
            units.AddRange(unit.units);
            unit.units.Clear();
        }

        public void ChangeAttackPoint(int point)
        {
            foreach (Unit unit in units)
            {
                Attackpoint = point;
            }
        }

        public void ChangeDefencePoint(int point)
        {
            foreach (Unit unit in units)
            {
                Defencepoint = point;
            }
        }

        public void ChangeMovePoint(int point)
        {
            foreach (Unit unit in units)
            {
                Extramovepoint = point;
            }
        }

        public void GoalUnit()
        {
            isGoaled = true;
        }
    }
}