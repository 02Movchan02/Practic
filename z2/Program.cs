using System;

namespace z2
{
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);
            usl u = new usl(x);
            if (x > 5)
            {
                if (x >= 8)
                {
                    Console.WriteLine("Ответ= "+u.res1);
                }
                else Console.WriteLine(u.NonR);
            }
            else if (x<-5)
            {
                if (x != 7)
                {
                    Console.WriteLine("Ответ= " + u.res2);
                }
                else Console.WriteLine(u.NonR);
            }
            else
            {
                if (x!=3)
                {
                    Console.WriteLine("Ответ= " + u.res3);
                }
                else
                {
                    Console.WriteLine(u.NonR);
                }
            }
        }
     }
}
