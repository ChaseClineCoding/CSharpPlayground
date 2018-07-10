using System;
using System.Collections.Generic;

namespace CSharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<int, bool> test = new Test<int, bool> {test1 = 1, test2 = true};
            Console.WriteLine(test.test2);
            Console.WriteLine(test.test1);
        }
    }
}
