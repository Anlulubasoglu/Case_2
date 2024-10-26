using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else

            //Console.WriteLine("Please Enter Password");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Password is True");
            //}
            //else {
            //    Console.WriteLine("Wrong Password!");
            //}

            //sayısal işlemlerde if-else

            //int number;
            //Console.Write("Enter Number");
            //number=int.Parse(Console.ReadLine());

            //if (number==5)
            //{
            //    Console.WriteLine("Number is True");
            //}
            //else
            //{
            //    Console.WriteLine("Number is False");
            //},

            //SınavOrtalamaBulma

            //int exam1, exam2, exam3, avg;
            //string result="0";

            //Console.Write("Exam-1 : ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Exam-2 : ");
            //exam2=int.Parse(Console.ReadLine()); 

            //Console.Write("Exam-3 : ");
            //exam3=int.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Exam Avg.: " + avg);

            //if (avg>0 & avg <=50)
            //{
            //    result="Exam Result Bad.";
            //}

            //if (avg>51 & avg<=75)
            //{
            //    result = "Exam Result Not yet.";
            //}

            //if (avg>76&avg<=100)
            //{
            //    result = "Exam ResultPerfect.";
            //}
            //Console.WriteLine(result);
            //Console.Read();

            //!= işaretinin anlamı Eşit Değilse demektir.

            //Console.Write("Please Enter UserName : ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Wrong UserNmae");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome.!");
            //}

            //Console.ReadLine();
            #endregion

            #region ModAlmaAritmetikİslemler

            //Console.Write("Enter Please Number One. : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Please Number Two. : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Result.: " + result);


            //Console.Write("Please Enter Number : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The remaining number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The remaining number is odd");
            //}


            //Console.Read();

            #endregion

            #region Char_Variables

            //char team;
            //Console.Write("Please enter the first letter of the team : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Your team is Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Your team is Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Your team is Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Your team is unknown");
            //}
            //Console.ReadLine();
            #endregion

            #region SampleApp

            //Console.WriteLine("Sample Cable Selection application");
            //Console.WriteLine("**********************************");
            //Console.WriteLine("1-Fiber Optic Cable");
            //Console.WriteLine("2-Telephone Cable");
            //Console.WriteLine("3-Electrical Cable");
            //Console.WriteLine("4-Internet UTP Cable");
            //Console.WriteLine("**********************************");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Please select a cable type: ");
            //menuItem = Console.ReadLine();
            //if (menuItem=="1")
            //{
            //    Console.WriteLine("Fiber Optic Cable Menu");
            //    Console.WriteLine("4 Core Fiber Optic Cable");
            //    Console.WriteLine("12 Core Fiber Optic Cable");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine("Telephone Cable Menu");
            //    Console.WriteLine("4 Core Cable");
            //    Console.WriteLine("12 Core Cable");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine("Electrical Cable Menu");
            //    Console.WriteLine("Anti-Gron Cable");
            //    Console.WriteLine("3x1.5 TTR Cable");
            //    Console.WriteLine("3x2.5 TTR Cable");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine("Internet Cable Menu");
            //    Console.WriteLine("Cat-5 UTP Cable");
            //    Console.WriteLine("Cat-6 UTP Cable");
            //    Console.WriteLine("Cat-7 UTP Cable");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a correct value");
            //}

            //Console.ReadLine();
            #endregion

            #region SwitchCase

            //Console.Write("Enter month number: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("month of january"); break;

            //    case 2:
            //        Console.WriteLine("month of february"); break;
            //    case 3:
            //        Console.WriteLine("month of March "); break;
            //    case 4:
            //        Console.WriteLine("month of April "); break;
            //    case 5:
            //        Console.WriteLine("month of May "); break;
            //    case 6:
            //        Console.WriteLine("month of June"); break;
            //    case 7:
            //        Console.WriteLine("month of July "); break;
            //    case 8:
            //        Console.WriteLine("month of August "); break;
            //    case 9:
            //        Console.WriteLine("month of September "); break;
            //    case 10:
            //        Console.WriteLine("month of October "); break;
            //    case 11:
            //        Console.WriteLine("month of November "); break;
            //    case 12:
            //        Console.WriteLine("month of December"); break;

            //    default:Console.WriteLine("Incorrect Login"); break;



            //}
            //Console.ReadLine();
            #endregion

            #region SwitchCaseWith Calculator

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Please enter the first number : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the second number : ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Please enter Mathematical symbol: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Result" + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Result" + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Result" + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Result : " + result);
            //        break;
            //    case '%':
            //        result = number1 % number2;
            //        Console.WriteLine("Result : " + result);
            //        break;
            //    default: Console.WriteLine("Incorrect Login"); break;

            //}

            //Console.ReadLine();
            #endregion
        }
    }
}
