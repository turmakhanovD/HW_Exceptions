using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForHWS
{
    public class Division
    {
        public int MakeDivision(int arg1,int arg2)
        {
            try
            {
                if (arg1 == null)
                {
                    throw new ArgumentNullException("Вы не передали значение!");
                }

                if (arg2 <= 0)
                {
                    throw new ArgumentException("Мы не можем делить на ноль или на отрицательное число!");
                }

                return (arg1 / arg2);
            }

            catch
            {
                 Console.WriteLine("Error");
                 return 0;
            }
        }
    }
}
