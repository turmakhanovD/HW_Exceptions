using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForHWS
{
    class Program
    {
        static void Main(string[] args)
        {
            Division division = new Division();
            Console.WriteLine( division.MakeDivision(25, 5) ); 
            Console.WriteLine( division.MakeDivision(25, 0) );

            int[] mas = { 5, 6, 765, 2342, 111, 444, 11234 };

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(mas[i] + "\t");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Выход за границы!");
            }
            finally
            {
                Console.WriteLine("Обработка завершена!");
            }

            Console.ReadLine();
        }
    }
}
