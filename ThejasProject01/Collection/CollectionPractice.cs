using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Collection
{
    internal class CollectionPractice
    {
        public static void Main()
        {
            //List
            //declaring initializing seperately
            var names= new List<string>();
            names.Add("virat");
            names.Add("rohit");
            Console.WriteLine(names[0]);  //virat

            //declaration and initialization at same time
            var name = new List<string> { "hardhik", "krunal" };//hardhik
            Console.WriteLine(name[0]);


            //HashSet
            var hs=new HashSet<int>();   
            hs.Add(15);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            hs.Add(30);
            hs.Add(10);

            foreach(var i in hs)
            {
                Console.Write(i+" "); //15 10 20 30
            }
        }
    }
}
