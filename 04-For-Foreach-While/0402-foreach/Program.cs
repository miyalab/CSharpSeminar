using System;

/// <summary>
/// foreachループ処理
/// </summary>
namespace _0402_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列のループ
            int sum = 0;
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(var num in values)
            {
                Console.WriteLine($"num={num}");
                sum = sum + num;
            }
            Console.WriteLine($"sum={sum}");

            // stringのループ
            string str = "Helloworld";
            foreach(var c in str)
            {
                Console.WriteLine(c);
            }
        }
    }
}
