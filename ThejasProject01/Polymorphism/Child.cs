using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Polymorphism
{
    public class Child : Parent01
    {
        public static void Main()
        {
            Parent01 p=new Child();

        }

        public void Test01()
        {
            Console.WriteLine("Child test 01");
        }

        public void Test02()
        {
            Console.WriteLine("Child test 02");
        }
         public void Test03()
        {
            Console.WriteLine("Child Test 03");
        }
    }
}
