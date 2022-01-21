using MyLibrabry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MallarDuck : Duck, IQuackable, IFlyable
    {
        public override string display()
        {
            return "display" + this.GetType();
        }

        public string quack()
        {
            return "QUUUAACCKK";
        }

        public string Fly()
        {
            return "MallarIsFlying";
        }
    }
}
