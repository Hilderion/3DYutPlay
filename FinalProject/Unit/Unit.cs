using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Unit
{
    public class Unit
    {
        public int AttackPoint { get; private set; }
        public int DefencePoint { get; private set; }
        public int ExtraMovePoint { get; private set; }

        public Position currentPosition { get; private set; }
        public Position formerPosition { get; private set; }
        public bool isSelected;
        public bool isGoalin;

        List<Unit> units = new List<Unit>();

        public void Addunit(Unit unit)
        {
            units.Add(unit);
        }

        private void ChangeAttackPoint(int point)
        {
            AttackPoint += point;
        }

        private void ChangeDefencekPoint(int point)
        {
            DefencePoint += point;
        }

        public int ChangeMovePoint(int point)
        {
            int unitmovepoint = point;
            unitmovepoint += ExtraMovePoint;
            return ExtraMovePoint;
        }
    }
}
