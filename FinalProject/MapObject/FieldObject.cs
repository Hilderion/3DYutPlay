using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class FieldObject : MapObject
    {
        Random random = new Random();
        int mapStatus, attack, defense;
        bool statusUpDown;

        public void Initial()
        {
            FieldObject fieldObject = new FieldObject();
            fieldObject.setmapType("Field");
            mapStatus = random.Next(1, 10);
            if (mapStatus % 2 == 0)
            {
                fieldObject.setTag("UpDown");
                attack = random.Next(-1, 1);
                defense = random.Next(-1, 1);
            }
                
            else
                fieldObject.setTag("Normal");
            
        }

        
    }
}
