using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class MountainObject : MapObject
    {
        int ThiefAttack;
        Random random = new Random();

        public void Initial()
        {
            MountainObject mountainObject = new MountainObject();
            mountainObject.setmapType("Mountain");
            mountainObject.setTag("Bandit");
            ThiefAttack = 1;
        }
    }
}
