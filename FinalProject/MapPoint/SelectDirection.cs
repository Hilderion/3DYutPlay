using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MapPoint
{
    class SelectDirection
    {
        public int Selectdirection(int corner)
        {
            int selectedDirection;
            String getDirection;


            if (corner == 1)
            {
                Console.WriteLine("Please select direction 2 or 5");
                getDirection = Console.ReadLine();
                selectedDirection = Convert.ToInt32(getDirection);
                return selectedDirection;

            }
            else if (corner == 2)
            {
                Console.WriteLine("Please select direction 3 or 6");
                getDirection = Console.ReadLine();
                selectedDirection = Convert.ToInt32(getDirection);
                return selectedDirection;

            }
            else if (corner == 3)
            {
                Console.WriteLine("Please select direction 4 or 7");
                getDirection = Console.ReadLine();
                selectedDirection = Convert.ToInt32(getDirection);
                return selectedDirection;

            }
            else
            {
                Console.WriteLine("Please select direction 8 or 9");
                getDirection = Console.ReadLine();
                selectedDirection = Convert.ToInt32(getDirection);
                return selectedDirection;
            }

        }
    }
}

