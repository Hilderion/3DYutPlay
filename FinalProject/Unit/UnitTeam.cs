using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class UnitTeam : Unit
    {
        public List<Unit> units;

        public UnitTeam(Unit unit1, Unit unit2) : base(unit1, unit2)
        {
            units.Add(unit1);
            units.Add(unit2);

            _Player = units.First()._Player;
            isGoaled = false;
            UnitPosition = unit1.UnitPosition;
            LocationHistory = unit1.LocationHistory;

            _Attack = units.Max(x => x._Attack);
            _Defense = units.Max(x => x._Defense);
            _Speed = units.Max(x => x._Speed);
        }

        public UnitTeam(List<Unit> unitlist, Unit unit) : base(unitlist, unit)
        {
            units = unitlist;
            units.Add(unit);

            _Player = units.First()._Player;
            isGoaled = false;
            UnitPosition = units.First().UnitPosition;
            LocationHistory = units.First().LocationHistory;

            _Attack = units.Max(x => x._Attack);
            _Defense = units.Max(x => x._Defense);
            _Speed = units.Max(x => x._Speed);
        }

        public UnitTeam(List<Unit> list1, List<Unit> list2) : base(list1, list2)
        {
            units = (List<Unit>)(list1.Union(list2));

            _Player = units.First()._Player;
            isGoaled = false;
            UnitPosition = units.First().UnitPosition;
            LocationHistory = units.First().LocationHistory;

            _Attack = units.Max(x => x._Attack);
            _Defense = units.Max(x => x._Defense);
            _Speed = units.Max(x => x._Speed);
        }
    }
}
