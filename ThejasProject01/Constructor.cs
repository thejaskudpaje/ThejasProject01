using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01
{
    public class ParentBase
    {
        public ParentBase(int i)
        {
            Console.WriteLine("Parent  without arguments");
        }
    }
    public class ChildThis : ParentBase
    {
        public ChildThis(int i) : base(20) 
        {
            Console.WriteLine("Child with one argument");
        }
        public ChildThis() : this(20) 
        {
            Console.WriteLine("Child without argument");
        }
    }
    internal class Constructor
    {
      /*  public static void Main()
        {
            ChildThis ct=new ChildThis();
        }
      */
    }
}
