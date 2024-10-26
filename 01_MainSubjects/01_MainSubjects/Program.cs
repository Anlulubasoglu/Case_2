using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.Write("Merhaba Dünya!");
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Menü");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine();
            Console.WriteLine("2-Soğuk Başlanıç");
            Console.WriteLine();
            Console.WriteLine("3-Ana Yemek");
            Console.WriteLine();
            Console.WriteLine("4-Ara Sıcak");
            Console.WriteLine();
            Console.WriteLine("5-Tatlı");
            Console.WriteLine();
            Console.WriteLine("6-İçecek");
            Console.WriteLine();

            #endregion

            #region Strıng_Degiskenler

            //string name = "Anıl";
            //Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail;
            string city, district;

            customerName = "Ali";
            customerSurname = "Demirbilek";
            customerPhone = "555 555 55 55";
            customerEmail = "test@test.com";
            city = "Adana"; district = "Seyhan";
            Console.WriteLine("////////////////////////");
            Console.WriteLine();
            Console.WriteLine("Rezarvasyon Bilgileri");
            Console.WriteLine();
            Console.WriteLine("Müşteri Adı Soyadı :" + customerName + " " + customerSurname);
            Console.WriteLine("Müşteri Telefon Nu.:" + customerPhone);
            Console.WriteLine("Müşteri E-Posta    :" + customerEmail);
            Console.WriteLine("Müşteri İl/İlçe    :" + city + " " + district);
            Console.WriteLine();
            Console.WriteLine("////////////////////////");
            Console.WriteLine();
            #endregion

            #region Int_Degıskenler

            //int number = 16;

            //Console.WriteLine("Ekrana yazılan Sayı : " + number);

            int kebabPrice = 300;
            int lahmacunPrice = 200;
            int ızgaraPrice = 150;
            int koftePrice = 150;
            int salgamPrice = 50;
            int colddrinkPrice = 40;

            Console.WriteLine("******Menü Fiyatları/Kebab Dünyası******");
            Console.WriteLine();
            Console.WriteLine("Kebab : " + kebabPrice + " TL");
            Console.WriteLine("Lahmacun : " + lahmacunPrice + " TL");
            Console.WriteLine("Izgara Çeşitleri : " + ızgaraPrice + " TL");
            Console.WriteLine("Köfte Çeşitleri : " + koftePrice + " TL");
            Console.WriteLine("Şalgam Çeşitleri : " + salgamPrice + " TL");
            Console.WriteLine("Soğuk İçecekler Çeşitleri : " + colddrinkPrice + " TL");
            Console.WriteLine();

            Console.WriteLine();

            int kebabCount = 3;
            int lahmacunCount = 3;
            int ızgaraCount = 3;
            int kofteCount = 0;
            int salgamCount = 3;
            int coldDrinkCount = 4;

            int totalKebabPrice;
            int totalLahmacubPrice;
            int totalIzgaraPrice;
            int totalKoftePrice;
            int totalSalgamPrice;
            int totalColddrinkPrice;

            totalKebabPrice = kebabCount * kebabPrice;
            totalLahmacubPrice = lahmacunCount * lahmacunPrice;
            totalIzgaraPrice = (int)ızgaraCount * (int)ızgaraPrice;
            totalKoftePrice = kofteCount * koftePrice;
            totalSalgamPrice = salgamCount * salgamPrice;
            totalColddrinkPrice = coldDrinkCount * colddrinkPrice;

            Console.WriteLine("Toplam Izgara Tutarı   :" + totalIzgaraPrice);
            Console.WriteLine("Toplam Kebab Tutarı    :" + totalKebabPrice);
            Console.WriteLine("Toplam Lahmacun Tutarı :" + totalLahmacubPrice);
            Console.WriteLine("Toplam Kofte Tutarı    :" + totalKoftePrice);
            Console.WriteLine("Toplam Salgam Tutarı   :" + totalSalgamPrice);
            Console.WriteLine("Toplam İçecek Tutarı   :" + totalColddrinkPrice);
            Console.WriteLine();
            Console.WriteLine("Toplam Adisyon : " + (totalKebabPrice + totalIzgaraPrice + (int)totalLahmacubPrice + totalKoftePrice + totalSalgamPrice + totalColddrinkPrice) + " TL");

            #endregion



            Console.ReadLine();
        }
    }
    }

