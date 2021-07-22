using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     System.Console.WriteLine("Bir sayı giriniz:");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Girmiş oldugunuz sayı :" + sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata: " + ex.Message.ToString());
            // }
            //finally
            //{
            //    System.Console.WriteLine("İşlem tamamlandı.");
            //}
            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş deger giriniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir deger girdiniz.");
                Console.WriteLine(ex);
            }
            finally{
                System.Console.WriteLine("İşlem başarıyla tamamlandı.");
            }


        }
    }
}
