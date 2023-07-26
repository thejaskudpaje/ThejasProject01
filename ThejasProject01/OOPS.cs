using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01
{

   public  abstract class GrandParent
    {
        abstract public void Test01();
        

        public virtual void Test02()
        {
            Console.WriteLine("grand parentTest02");
        }

    }
    public  class Parent : GrandParent
    {
        public static int i = 10;
        /*declaring private variable*/
        private int PrValue;
        public int PuValue
        {
            get { return PrValue; }
            set { PrValue = value;}
        }

        public static void ParentTest01()
        {
            Console.WriteLine("Test 01 Of parent class");
        }

        public override sealed void Test01()
        {
            Console.WriteLine("parentTest01");
        }

        public virtual void Test02()
        {
            Console.WriteLine(" parentTest02");
        }

    }

     class Child : Parent
    {
        public static void Inherit()
        {
            Console.WriteLine(i);
           // ParentTest01();
        }

        public  void Encap(Object p)
        {
            Parent p1=new Parent();
            /*Setter*/ 
            p1.PuValue = 100;

            /*getter*/
            Console.WriteLine(p1.PuValue);


        }

        public override sealed void Test02()
        {
            Console.WriteLine("child Test02");
        }

    }

    internal class OOPS
    {
   /*     public static void Main()
        {
            Child c=new Child();
            Console.WriteLine("executing inheritance");
            Child.Inherit();

            Parent p =new Parent();
            Console.WriteLine("executing Encapsulation");
            c.Encap(p);

            GrandParent gp1=new Parent();
            Console.WriteLine("executing abstraction and polymorphism");
            Console.WriteLine();
            gp1.Test01();

            GrandParent gp2 = new Child();
            gp2.Test02();

        }

        */

    }
}
