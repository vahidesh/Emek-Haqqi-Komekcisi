using System;

namespace Emek_Haqqi_Komekcisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umumi emek haqqini daxil edin: ");
            int x = int.Parse(Console.ReadLine()); //umum emek haqqi
            Console.WriteLine("Aile veziyyetiniz - e(evli),s(subay),d(dul)!");
            string y =Console.ReadLine();//aile veziyyeti


            int u = 0;//usaq sayi
            float gs = 0;//gross
            float v = 0;//vergi meblegi
            string f = "";//fiziki qusur
            int i= 0;//usaq pulu
            int aile = 0;//aile muavinati

            if (y == "d")
            {
                Console.WriteLine("Usaq var? b(beli), x(xeyr)");
                string p = Console.ReadLine();
                if (p == "b")
                {
                    Console.WriteLine("Usaq sayini daxil et");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f  = Console.ReadLine();
             
            }
             if (y == "e")
            {
                Console.WriteLine("Usaqiniz var? b(beli), x(xeyr)");
                string p = Console.ReadLine();
                if (p == "b")
                {
                    Console.WriteLine("Usaq sayini daxil edin");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f = Console.ReadLine();
                
            }
            if (y == "s")
            {
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f = Console.ReadLine();

            }
            if (y == "e")
            {
                aile = 50;
                gs = x + aile;
            }
            else
            {
                aile = 0;
                gs = x + aile;
            }
            if (u == 1)
            {
                i = 30;
                gs = gs + i;
            }
            if (u == 2)
            {
                i = 55;
                gs = gs + i;
            }
            if (u == 3)
            {
                i = 75;
                gs = gs + i;
            }
            if (u > 3)
            {
                i = 75 + 15 * (u - 3);  
                gs = gs + i;
            }
            if (gs <= 1000)
            {
                v = gs * 15 / 100;
            }
            if (gs < 2000 && gs > 1000)
            {
                v = gs * 20 / 100;
            }
            if (gs >= 2000 && gs < 3000)
            {
                v = gs * 25 / 100;
            }
            if (gs >= 3000)
            {
                v = gs * 30 / 100;
            }
            if (f == "b")
            {
                v = v * 50 / 100;
            }
            gs = gs - v;
            Console.WriteLine($"Aile muavinati-{aile} ");
            Console.ReadLine();
            Console.WriteLine($"Usaq pulu-{i}");
            Console.ReadLine();
            Console.WriteLine($"Vergi meblegi-{v}");
            Console.ReadLine();
            Console.WriteLine($"Umumi emek haqqi-{x}");
            Console.ReadLine();
            Console.WriteLine($"Xalis emek haqqi-{gs}");

            int range  = (int) Math.Floor(gs / 200);
            int range1 = (int) Math.Floor((gs - range * 200) / 100);
            int range2 = (int) Math.Floor(((gs - range * 200) - range1 * 100) / 50);
            int range3 = (int) Math.Floor((((gs - range * 200) - range1 * 100) - range2 * 50) / 20);
            int range4 = (int) Math.Floor(((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) / 10);
            int range5 = (int) Math.Floor((((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) - range4 * 10) / 5);
            int range6 = (int) Math.Floor(((((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) - range4 * 10) - range5 * 5) / 1);

            Console.WriteLine(range + "x 200");
            Console.WriteLine(range1 + "x 100");
            Console.WriteLine(range2 + "x 50");
            Console.WriteLine(range3 + "x 20");
            Console.WriteLine(range4 + "x 10");
            Console.WriteLine(range5+ "x 5");
            Console.WriteLine(range6 + "x 1");

        }
    }
}
