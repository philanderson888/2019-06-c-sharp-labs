using System;
using System.Collections.Generic;
using System.Text;

namespace lab_19_polymorphism
{
    class Child01 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("Have fun with kids in pool");
        }
    }
}
