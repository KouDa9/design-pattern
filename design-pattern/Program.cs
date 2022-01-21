using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using MyLibrabry;

namespace MyLR
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck duck1 = new MallarDuck();
            RedheadDuck duck2 = new RedheadDuck();
            RubberDuck rub = new RubberDuck();
            DecoyDuck dec = new DecoyDuck();

            Duck[] mas = new Duck[] { duck1, duck2, rub, dec };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
                
                if(mas[i] is IQuackable)
                    Console.WriteLine((mas[i] as IQuackable).quack());

                if (mas[i] is IFlyable)
                    Console.WriteLine((mas[i] as IFlyable).Fly());
                Console.WriteLine("__________");
            }

            Console.ReadKey();
        }
    }
}

