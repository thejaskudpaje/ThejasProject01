using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Polymorphism
{
    public abstract class Parent01
    {
        public virtual void Test01()
        {
            Console.WriteLine("Parent test 01");
        }

        abstract public void Test02();

         public virtual void Test03()
        {
            Console.WriteLine("Parent Test 03");
        }
    }
}
