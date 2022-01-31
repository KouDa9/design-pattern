using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyLibrary
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        public override string display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
    }
}
