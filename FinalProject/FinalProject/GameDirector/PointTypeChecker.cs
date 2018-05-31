using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.GameDirector
{
        class PointTypeChecker
        {
            private string _pointTag;
            private string _currentPoint;

            public string PointTypeCheck()
            {
                if (_pointTag == "Mountain")
                {
                    _currentPoint = "Mountain";
                    return "Mountain";
                }

                else if (_pointTag == "UnderGround")
                {
                    _currentPoint = "UnderGround";
                    return "UnderGround";
                }

                else if (_pointTag == "Field")
                {
                    _currentPoint = "Field";
                    return "Field";
                }

                else if (_pointTag == "Well")
                {
                    _currentPoint = "Well";
                    return "Well";
                }

                return "Default";
            }

        }
    }

