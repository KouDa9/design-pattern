using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyLibrary
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
        public override string display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }

    }
}
