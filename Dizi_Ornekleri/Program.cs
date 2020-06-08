using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tanımlanan Dizi ifadesini alfabetik sıralamaya göre alt alta yazdıralım
            string[] personellistesi = new string[5] { "Mehmet Erten", "Mustafa Ay", "Aynur Kaymak", "Meltem Ay", "Cumhur Türkmen" };
            Array.Sort(personellistesi);
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("{0}", personellistesi[i]);
            }
            Console.ReadKey();*/


            /* Haftanın Günlerinin Metinsel ve Sayısal Kısmının Ekrana Yazdırılması
            string[] gunler1 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşama", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(gunler1[i] + " " + gunler2[i]);
            }
            Console.ReadKey();*/


            /*Öğrenci No ve Öğrenci 3 yazılı notunun ortalamasının ekrana yazdırılması
            string[] ogrenciler = new string[5] { "101", "102", "103", "104", "105" };
            int[,] notlar = new int[5, 3] { { 50, 60, 70 }, { 50, 50, 50 }, { 40, 60, 50 }, { 80, 70, 90 }, { 85, 85, 85 } };
            int j = 0;
            for (int i = 0; i <=4 ; i++)
            {
                double ortalama = (notlar[i,j] + notlar[i,j+1] + notlar[i,j+2]) / 3;
                Console.WriteLine("Öğrenci No:{0}  Ortalama:{1}", ogrenciler[i], ortalama);
            }
            Console.ReadKey();*/


            /*13 Elemanlı Bir Dizi İçerisinde Çift Sayıların Ekrana Yazdırılması
            int[] ciftsayilar = new int[13];
            int sayi = 0;

            for (int i = 0; i <=12; i++)
            {
                ciftsayilar[i] = sayi;
                Console.WriteLine("{0}", ciftsayilar[i]);
                sayi = sayi + 2;
            }
            Console.ReadKey();*/
        }
    }
}
