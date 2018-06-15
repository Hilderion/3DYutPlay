using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        public int No { get; private set; }

        public Player(int no)
        {
            No = no;
            Horses = new List<Horse>();
            
        }

        public List<Horse> Horses { get; private set; }

        public bool IsWon => Horses.All(x => x.Finished);

    }
}
