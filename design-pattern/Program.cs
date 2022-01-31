using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace MyLR
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck mal = new MallarDuck();
            Duck red = new RedheadDuck();
            RubberDuck rub = new RubberDuck();
            DecoyDuck dec = new DecoyDuck();

            IFlyBehavior fnw = new FlyNoWay();
            IQuackBehavior mq = new MuteQuack();

            Duck[] mas = new Duck[] { mal, red, rub, dec };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].fly());
                Console.WriteLine(mas[i].quack());
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
                Console.WriteLine("__________");
            }

            Console.ReadKey();
        }
    }
}

