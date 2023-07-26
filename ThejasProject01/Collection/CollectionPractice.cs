using System;
using System.Collections.Concurrent;
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
            Console.WriteLine("Output of List");
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
            Console.WriteLine("\nOutput of HashSet");
            //Printing using for each loop
            foreach (var i in hs)
            {
                Console.Write(i+" "); //15 10 20 30
            }
            Console.WriteLine();

            //SortedSet
            var ss=new SortedSet<char>();
            ss.Add('m');
            ss.Add('n');
            ss.Add('a');
            ss.Add('i');
            ss.Add('m');
            ss.Add('c');
            Console.WriteLine("\nOutput of SortedSet");
            //Printing using for each loop
            foreach (var i in ss)
            {
                Console.Write(i + " "); //a c i m n
            }

        }
    }
}
