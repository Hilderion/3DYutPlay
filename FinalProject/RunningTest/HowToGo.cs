﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.MoveDirector;

namespace FinalProject.RunningTest
{
    class HowToGo
    {
        public List<double> Directionsetting(List<double> currentposition, int direction)
        {
            List<double> destination = new List<double> ();

            if (direction == 1)
            {
                currentposition[0] += 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 2)
            {
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 3)
            {
                currentposition[0] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 4)
            {
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 5)
            {
                currentposition[0] -= 3;
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 6)
            {
                currentposition[0] -= 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 7)
            {
                currentposition[0] += 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else if (direction == 8)
            {
                currentposition[0] -= 3;
                currentposition[2] -= 3;
                destination = currentposition;
                return destination;
            }
            else
            {
                currentposition[0] -= 3;
                currentposition[2] += 3;
                destination = currentposition;
                return destination;
            }

        }
    }

}

