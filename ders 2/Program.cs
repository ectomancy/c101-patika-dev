using System;

namespace ders_2
{
    class Program
    {
        static  void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompleted =false;
             
             if(isSuccess && isCompleted)
             Console.WriteLine("perfect");
             if(isSuccess || isCompleted)
             Console.WriteLine("Great");

             int a = 3;
             int b= 4;

             bool sonuc = a<b;
             Console.WriteLine(sonuc);
             sonuc = a>b;
             Console.WriteLine(sonuc);
             sonuc = a>=b;
             Console.WriteLine(sonuc);
             sonuc = a<=b;
             Console.WriteLine(sonuc);
             sonuc = a!=b;
             Console.WriteLine(sonuc);
             sonuc = a==b;
             Console.WriteLine(sonuc);
             

        }
    }
}
