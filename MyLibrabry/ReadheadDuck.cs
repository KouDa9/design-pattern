using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override string display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
    }
}