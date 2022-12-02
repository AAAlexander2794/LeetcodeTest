using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1603
    {
        public class ParkingSystem
        {
            private int[] Spaces = new int[] { 0, 0, 0 };

            public ParkingSystem(int big, int medium, int small)
            {
                Spaces[0] = big;
                Spaces[1] = medium;
                Spaces[2] = small;
            }

            public bool AddCar(int carType)
            {
                if (Spaces[carType - 1] > 0)
                {
                    Spaces[carType - 1]--;
                    //Console.Write($"{carType}-{Spaces[carType - 1]} ");
                    return true;
                }
                else return false;
            }
        }

        /**
         * Your ParkingSystem object will be instantiated and called as such:
         * ParkingSystem obj = new ParkingSystem(big, medium, small);
         * bool param_1 = obj.AddCar(carType);
         */
    }
}
