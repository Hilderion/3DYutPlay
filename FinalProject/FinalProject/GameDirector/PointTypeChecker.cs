using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
    class PointTypeChecker
    {
        FieldObject fieldObject = new FieldObject();
        UnderGroundObject underGroundObject = new UnderGroundObject();
        MountainObject mountainObject = new MountainObject();

        private string _currentPoint;

        public string PointTypeCheck()
        {
            if (mountainObject.getmapType() == "Mountain")
            {
                _currentPoint = "Mountain";
                return "Mountain";
            }

            else if (underGroundObject.getmapType() == "Under")
            {
                _currentPoint = "UnderGround";
                return "UnderGround";
            }

            else if (fieldObject.getmapType() == "Field")
            {
                _currentPoint = "Field";
                return "Field";
            }

            else if (underGroundObject.getTag()== "Well")
            {
                _currentPoint = "Well";
                return "Well";
            }

            else if (mountainObject.getTag()=="Bandit")
            {
                _currentPoint = "Bandit";
                return "Bandit";
            }

            return "Default";
        }
        
    }
}

