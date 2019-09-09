using System;

namespace HackerRank_Solve_Me_First
{
    class Program
    {
        static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //First integer value declaration and converted to Int32 type.
            int val1 = Convert.ToInt32(Console.ReadLine());
            //Second integer value declaration and converted to Int32 type.
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(val1, val2);
            Console.WriteLine(sum);
            //To prevent the console from automatically closing upon completion of program
            Console.Read();
        }
    }
}
