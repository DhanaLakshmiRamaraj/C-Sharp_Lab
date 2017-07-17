using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hai", s1 = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                s1 = s1 + s[i];
            }
            Console.WriteLine(s1);
        }
    }
}
