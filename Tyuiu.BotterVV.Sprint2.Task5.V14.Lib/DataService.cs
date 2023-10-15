using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotterVV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res;
            d = 7;
            if (k < 366 && k > 0)
            {
                switch ((k) % d)
                {
                    case 1:
                        res = "Понедельник";
                        break;
                    case 2:
                        res = "Вторник";
                        break;
                    case 3:
                        res = "Среда";
                        break;
                    case 4:
                        res = "Четверг";
                        break;
                    case 5:
                        res = "Пятница";
                        break;
                    case 6:
                        res = "Суббота";
                        break;
                    case 0:
                        res = "Воскресенье";
                        break;
                    default:
                        throw new ArgumentException($"В неделе от 1 до 7 дней. Значение {(k) % d}");
                }
            }
            else
            {
                throw new ArgumentException("В году 365 дней.");
            }
            return res;
        }
    }
}
