using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            //System.Console.WriteLine("Lütfen bir sayi giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;            
            // while (sayac <= sayi)
            // {
            //      toplam+= sayac;
            //      sayac ++;
            // }
            // System.Console.WriteLine(toplam/sayi);

            // // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
            // char character = 'a';
            // while (character <'z')
            // {
            //      System.Console.WriteLine(character);
            //      character ++;
            // }

            System.Console.WriteLine("******* Foreach ******");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}
