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
            Console.WriteLine(names[0]);

            //declaration and initialization at same time
            var name = new List<string> { "hardhik", "krunal" };
            Console.WriteLine(name[0]);

        }
    }
}
