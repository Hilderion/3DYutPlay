using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        public int PlayerNumber;
        public List<Unit> Owned;

        public Unit Knight;
        public Unit HeavySoldier;
        public Unit Guard;
        public Unit Scout;
        public void MakePlayer(int playerNumber)
        {
            PlayerNumber = playerNumber;

            Knight = new Unit(playerNumber, UnitTag.Knight);
            HeavySoldier = new Unit(playerNumber, UnitTag.HeavySoldier);
            Guard = new Unit(playerNumber, UnitTag.Guard);
            Scout = new Unit(playerNumber, UnitTag.Scout);

            //Owned.Add(Knight);
            //Owned.Add(HeavySoldier);
            //Owned.Add(Guard);
            //Owned.Add(Scout);
        }

    }
}
