using System;

namespace CSharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] {"Hello", "World"};
            GoToStatement(strings);
        }

        static void GoToStatement(string[] args)
        {
            int i = 0;
            goto titty;
            farty:
            Console.WriteLine(args[i++]);
            titty:
            if (i < args.Length)
                goto farty;
        }
    }
}
