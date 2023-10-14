using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotterVV.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x < 3 || x > 13) || (y < 3 || y > 13)) || ((x == 6 || x == 7 || x == 8) && (y == 3 || y == 4)) || ((x == 3) && (y == 8 || y == 9 || y == 10 || y == 12 || y == 13)) || ((y == 9 || y == 10 || y == 11) && (x == 6 || x == 7 || x == 8 || x == 9)) || ((y == 12) && (x == 7 || x == 8 || x == 9 || x == 11 || x == 12 || x == 13)) || ((y == 13) && (x == 7 || x == 8 || x == 9 || x == 10 || x == 11 || x == 12 || x == 13)) || ((x == 13) && (y == 3 || y == 4 || y == 5 || y == 9 || y == 10 || y == 11 || y == 12 || y == 13)))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
    }
}
