using System;

namespace Arvuppgift{

    class Program{

        static void Main(){

            Console.WriteLine("Skriv in ditt bas mått");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ditt höjd mått");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv t för triangel eller r för rektangel");
            string s = Console.ReadLine();

            switch(s){

                case "t": 
                Shape tri = new Triangle(h, w);
                Console.WriteLine(tri.Area());
                Console.WriteLine(tri.Circumference());
                break;

                case "r":
                Shape rec = new Rectangle(h,w);
                Console.WriteLine(rec.Area());
                Console.WriteLine(rec.Circumference());
                break;

            }
        }
    }
}