using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace MyLibrary
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string swim()
        {
            return "Буль буль буль";
        }

        public abstract string display();

        public string fly()
        {
            return flyBehavior.fly();
        }

        public string quack()
        {
            return quackBehavior.quack();
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
