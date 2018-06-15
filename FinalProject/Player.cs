#region
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace FinalProject
{
    public class Player
    {
        public int Id { get; }

        public Player(int id)
        {
            Id = id;
            Horses = new List<Horse>();

            HorseType[] horseTypes = (HorseType[]) Enum.GetValues(typeof(HorseType));
            foreach (var horseType in horseTypes)
                Horses.Add(Horse.Create(this, horseType));
        }

        public List<Horse> Horses { get; }

        public bool IsWon => Horses.All(x => x.Finished);

        public void MoveHorse(HorseType horseType, int dice)
        {
//            Horses[(int) horseType].
        }
    }
}