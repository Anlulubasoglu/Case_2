using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach Dögüsü 4 tane bileşen alır
            //1:Değişken Türü
            //2:Değişken Adı
            //3: In Komutu
            //4:Liste,koleksiyon.

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #region Sınav Uygulması

            //Öğrenci Sayısını Kullanıcıdan Alma, Kullanıcıya Veri Girişi Yaptırma

            Console.Write("C# Eğitim M&Y Yazılım Sınav Sonuç Uygulması");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************");
            Console.Write("Sınıf Mevcudu : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************");

            string[] studentName = new string[studentCount];
            //Dizinin sonuna yazdığımız studentCount ile dizi boyutunu kullanıcıdan gelen veri kadar alıyoruz
            //Yani dizi boyutunu kullanıcı verisi belirliyor.

            double[] examAvg = new double[studentCount];
            //Burada double ile notların küsaratlı olacağını bildiriyoruz.
            //Yine dizi sonunda studentCount değişkeni ile dizi boyutu kullanıcının belirttiği kadar oluyor


            //For döngüsü ile başlangıç değerini 0 olarak verdik ve studentCount değişkeni kullanıcının verdiği sayı olana kadar 1er artacak.
            for (int i = 0; i < studentCount; i++)
            {
                //$: Bu sembol, C# 6 ile gelen bir özellik olan string interpolasyonu için kullanılır.
                //String interpolasyonu, metin içine değişken veya ifadeler yerleştirmeyi kolaylaştırır.
                Console.Write($"{i + 1} öğrencinin adını girin : ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    //{studentName[i]} kısmında kullanıcı tarafından girilen isim studentName değişkenine atanıyor ve i kısmı for döngüsünde çalışıyor.
                    //j değişkeni for döngüsü içerisinde başlangıcı 0 olduğu için {j+1} yazılır ve 1'inci sırdan den başlatılır 
                    Console.Write($"{studentName[i]} öğrencinin {j + 1} .inci Sınav Notunu girin : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // sınav notlarını toplamak için 

                }
                Console.WriteLine();
                examAvg[i] = totalExamResult / 3;

            }

            //Sınav sonucuna göre geçip Kalma durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrenicinin ortalaması : {examAvg[i]}");

                if (examAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} İsimli Öğrenci Geçti");
                }
                if (examAvg[i] <= 50)
                {
                    Console.WriteLine($"{studentName[i]} İsimli Öğrenci Kaldı");
                }
            }
            #endregion
            Console.Read();
        }
    }
}
