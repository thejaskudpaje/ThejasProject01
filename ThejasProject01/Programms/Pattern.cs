using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Programms
{
    internal class Pattern
    {
        public void execute()
        {
            Console.WriteLine();
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= 1; j--)
                {

                    Console.Write(" *  ");
                }
                Console.WriteLine();
            }
        }
    }
}
