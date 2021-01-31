using System;

/// <summary>
/// forループ処理
/// </summary>
namespace _0401_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(初めに実行される処理; 条件式; 後置処理)
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i={i}");
            }

            // 配列とforループの組み合わせ
            int sum = 0;
            int[] values = new int[5] { 1, 2, 3, 4, 5 };
            for(int i = 0; i < values.Length; i++)
            {
                sum = sum + values[i];
            }
            Console.WriteLine($"sum={sum}");

            // 二重forループ
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"(i.j)=({i},{j})");
                }
            }
        }
    }
}
