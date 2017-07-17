using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfStringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            //Stringbuilder
            //StringBuilder is mutable, means if create string builder object then you can perform 
            //any operation like insert, replace or append without creating new instance 
            //for every time.it will update string at one place in memory doesnt create 
            //new space in memory.

            #region String Concatenation Using string builder
            StringBuilder s = new StringBuilder("Start");
            Console.WriteLine("String Concatenation using string builder started");
            //for (int i = 0; i < 10000000; i++)
            //{
            //    s.Append(i.ToString());
            //}

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Execution Time :{s} {ts.Hours}:{ts.Minutes}:{ts.Seconds}");
            Console.WriteLine("String Concatenation using string builder ended");

            #endregion

            //String
            //String is immutable, Immutable means if you create string object 
            //then you cannot modify it and It always create new object of string type in memory.

            #region String Concatenation Using +
            string test = string.Empty;
            stopwatch.Restart();

            Console.WriteLine("String Concatenation using + started");
            for (int i = 0; i < 10000000; i++)
            {
                test += i;
            }
            stopwatch.Stop();
            TimeSpan ts1 = stopwatch.Elapsed;
            Console.WriteLine($"Execution Time : {ts1.Hours}:{ts1.Minutes}:{ts1.Seconds}");
            Console.WriteLine("String Concatenation using + ended");
            #endregion

            Console.Read();
        }
    }
}
