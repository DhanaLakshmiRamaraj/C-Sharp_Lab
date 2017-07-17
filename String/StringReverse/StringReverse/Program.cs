using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "Hai";
            char[] s = sample.ToCharArray();
            
            Console.WriteLine(s);
            for (int i = s.Length-1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
            
        }
    }
}
