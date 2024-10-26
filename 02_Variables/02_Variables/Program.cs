using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region using_Double

            //double number = 4.85;
            //Console.WriteLine(number);
            //Console.ReadLine();


            //Console.WriteLine("*****Adana Meyve Fiyat Listesi******");
            //Console.WriteLine();

            //double applePrice, orangePrice, pinapplePrice, berryPrince, melonPrice;

            //applePrice = 5.85;
            //orangePrice = 3.43;
            //pinapplePrice = 6.53;
            //berryPrince = 7.27;
            //melonPrice = 4.38;

            //Console.WriteLine("Elma fiyatı     :  " + applePrice + " ₺");
            //Console.WriteLine("Portakal fiyatı :  " + orangePrice + " ₺");
            //Console.WriteLine("Ananas fiyatı   :  " + pinapplePrice + " ₺");
            //Console.WriteLine("Böğörtlen fiyatı:  " + berryPrince + " ₺");
            //Console.WriteLine("Kavun fiyatı    :  " + melonPrice + " ₺");

            //double applegram, orangegram, pinapplegram, berrygram, melongram;

            //applegram = 0.5;
            //orangegram = 1.5;
            //pinapplegram = 0.8;
            //berrygram = 2.5;
            //melongram = 1.2;


            //double appleTotalPrice;
            //double orangeTotalPrice;
            //double pinappleTotalPrice;
            //double berryTotalPrice;
            //double melonTotalPrice;

            //appleTotalPrice = (applePrice * applegram);
            //orangeTotalPrice = (orangePrice * orangegram);
            //pinappleTotalPrice = (pinapplePrice * pinapplegram);
            //berryTotalPrice = (berryPrince * berrygram);
            //melonTotalPrice = (melonPrice * melongram);
            //Console.WriteLine();

            //Console.WriteLine("***********************************");
            //Console.WriteLine();
            //Console.WriteLine("Elma Toplam Fiyat      :" + appleTotalPrice + " ₺");
            //Console.WriteLine("Portakal Toplam Fiyat  :" + orangeTotalPrice + " ₺");
            //Console.WriteLine("Ananas Toplam Fiyat    :" + pinappleTotalPrice + " ₺");
            //Console.WriteLine("Böğürtlen Toplam Fiyat :" + berryTotalPrice + " ₺");
            //Console.WriteLine("Kavun Toplam Fiyat     :" + melonTotalPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün Toplam Fiyat : " + (appleTotalPrice + orangeTotalPrice) + " ₺");
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #region using_Char

            //char symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region using_dataİnputFromKeyboard

            //Console.Write("Information of the Student of English Private Lesson: ");
            //Console.WriteLine();
            //string studentName, studentSurname, studentEmail, studentAdress;
            //int studentPhone, studentAge;
            //Console.WriteLine();

            //Console.Write("Student Name : ");
            //studentName = Console.ReadLine();
            //Console.Write("Student Surname : ");
            //studentSurname = Console.ReadLine();
            //Console.Write("Student Phone : ");
            //studentPhone = int.Parse(Console.ReadLine());
            //Console.Write("Student Email : ");
            //studentEmail = Console.ReadLine();
            //Console.Write("Student Adress : ");
            //studentAdress = Console.ReadLine();
            //Console.Write("Student Age : ");
            //studentAge = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("********************************");
            //Console.WriteLine("Student Name: " + studentName + "Student Surname" + studentSurname);
            //Console.WriteLine("Student Phone: " + studentPhone);
            //Console.WriteLine("Student Email: " + studentEmail);
            //Console.WriteLine("Student Adress: " + studentAdress);
            //Console.WriteLine("Student Age: " + studentAge);

            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #region Integer Input and Conversions From The Keyboard

            //int shoesPrice, compPrice, tvPrice;

            //shoesPrice = 1200;
            //compPrice = 30000;
            //tvPrice = 15000;
            //int shoesCount, compCount, tvCount;

            //Console.Write("Please Enter The Amount Of The Shoes That You Bought :");
            //shoesCount = int.Parse(Console.ReadLine());



            //Console.Write("Please Enter The  Of The Computer Amount That You Bought :");
            //compCount = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter The Amount  Of The Television That You Bought :");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + compPrice * compCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Total Amount That You Need To Pay : " + totalPrice+"$");

            #endregion

            #region Decimal Number Input and Conversions From The Keyboard

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter the first exam point : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the second exam point : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the third exam point : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Exam Average Point : " + result);

            #endregion

            #region Character Input From The Keybord

            //char gender;
            //Console.Write("Please Choose Gender : ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("The Gender You Chose : " + gender);

            #endregion

            Console.ReadLine();
        }
    }
}


