using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.month;

            //Expression

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;        
                case 3:
                    Console.WriteLine("Mart ayındasınız!");
                    break;   
                default:
                    Console.WriteLine("Yanlış veri girişiniz!");
                break;        

                switch (switch_on)
                {
                    case 12:
                    case 1:
                    case 2:
                        System.Console.WriteLine("Kış Ayındasınız!");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        System.Console.WriteLine("İlkbahar Ayındasınız!");
                    break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Yaz Ayındasınız!");
                    break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Yaz Ayındasınız!");
                    break;
                    default:
                    break;

                } 
        }
    }
}
