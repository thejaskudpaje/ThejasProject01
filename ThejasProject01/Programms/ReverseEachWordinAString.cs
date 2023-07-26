using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThejasProject01.Programms
{
    internal class ReverseEachWordinAString
    {
        public void execute()
        {
            string s = "Im a sdet engineer";
            string[] sa = s.Split(" ");
            for (int i = 0; i < sa.Length; i++)
            {
                string r = sa[i];
                for (int j = r.Length - 1; j >= 0; j--)
                {
                    Console.Write(r.ElementAt(j));
                }
                Console.Write(" ");
            }
        }
    }
}
