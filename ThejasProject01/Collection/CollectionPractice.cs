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
            Console.WriteLine();  

            //Stack
            var st=new Stack<String>();
            st.Push("Banana");
            st.Push("Apple");
            st.Push("Banana");
            st.Push("Orange");
            st.Push("jackfruite");
            //printing as LIFO order
            foreach (var i in st)
            {
                Console.Write(i + " "); //jackfruite Orange Banana Apple Banana
            }

            //Printing and deleting last in element
            Console.WriteLine("\n"+st.Pop());

            //printing after pop
            foreach (var i in st)
            {
                Console.Write(i + " "); // Orange Banana Apple Banana
            }

             var a=st.Peek();
            Console.WriteLine(a);//Orange

            
            //Queue
            var q=new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            //Printing as FIFO order
            foreach (var i in q)
            {
                Console.Write(i + " "); // 10 20 30 40
            }
            Console.WriteLine();
            //removing first element and printing
            q.Dequeue();
            foreach (var i in q)
            {
                Console.Write(i + " "); //  20 30 40
            }

        }
    }
}
