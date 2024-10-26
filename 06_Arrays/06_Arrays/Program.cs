using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizilerde önce Tür belirnelir'Strin,int,double yada char' gibi sonra köşeli parantez açılır
            //Açılan köşeli parantez onun bir dizi olduğunu belirtir
            // new.... [] parantezin içine dizi boyutu belirlenir.
            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //colors[3] = "White";
            //Console.WriteLine(colors[1]);
            //Console.WriteLine(colors[2]);
            //Console.WriteLine(colors[3]);


            //string[] person = { "ali","akın","fatih" };
            //Console.WriteLine(person.LongLength);

            int[] number = { 45, 56, 98, 77, 52, 31, 33 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }
            Console.WriteLine("***************************");
            Console.WriteLine("Tek Sayı");
            Console.WriteLine(' ');
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] % 2 == 1)
                {
                    Console.WriteLine(number[i]);
                }
            }


            Console.Read();
        }
    }
}
