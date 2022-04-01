using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int Time = DateTime.Now.Hour;
            
            if(Time>=6 && Time<11)
            Console.WriteLine("günaydın!");

            else if(Time>=10 && Time<=18)
            Console.WriteLine("iyi akşamlar!");
             
             else if(Time>=20)
             Console.WriteLine("iyi geceler!");

             string sonuc = Time<=18 ? "iyi günler!" : "iyi geceler";
             
          



        }
    }
}