using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Polymorphism
{
    public class Child : Parent01
    {
      /*  public static void Main()
        {
            Console.WriteLine("upcasted object");
            Parent01 p=new Child();
            p.Test01();
            p.Test02(); 
            p.Test03();

            Child c=new Child();
            Console.WriteLine("Child object");
            c.Test01(); 

        }*/

        public override void Test01()
        {
            Console.WriteLine("Child test 01");
        }
         override
        public void Test02()
        {
            Console.WriteLine("Child test 02");
        }
        
         public override sealed void Test03()
        {
            Console.WriteLine("Child Test 03");
        }
    }
}
