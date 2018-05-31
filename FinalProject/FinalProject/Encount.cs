using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Encounter
    {
        public void Enemy(MapObject map)
        {
            if (map.P1units.Max(x => x._Defense) < map.P2units.Max(x => x._Attack))
            {
                foreach (Unit dead in map.P1units)
                {
                    dead.FieldLocation = new int[3] { 0, 0, 0 };
                    dead.LocationHistory.Clear();
                }
                map.P1units.Clear();
                map.P1units = map.P2units;
                map.P2units.Clear();
            }
            else
            {
                //유닛들 움직이는 메소드 필요
            }
        }
    }
}
