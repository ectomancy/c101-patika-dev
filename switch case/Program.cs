using System;

namespace _07_switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış verindasınız");
                    break;
            }

            switch (ay)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                default:
                    Console.WriteLine("Mevsim Belirsiz");
                    break;

            }
        }
    }
}