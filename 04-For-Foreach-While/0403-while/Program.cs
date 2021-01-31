using System;

/// <summary>
/// whileループ処理
/// </summary>
namespace _0403_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while(i < 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }
}
