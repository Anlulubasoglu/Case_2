using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Drawing a Figure

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion

            #region
            int satir = 5;

            // Üst kısım (üçgen)
            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= satir - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Alt kısım (ters üçgen)
            for (int i = satir - 1; i >= 1; i--)
            {
                for (int j = 1; j <= satir - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion
        }
    }
}

