using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class UnderGroundObject : MapObject
    {
        int position, center;

        public void Initial()
        {
            UnderGroundObject underGround = new UnderGroundObject();
            underGround.setmapType("Under");

            if (position == center)
                underGround.setTag("Well");
            else
                underGround.setTag("Normal");
        }
    }
}
