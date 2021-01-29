using System;

/// <summary>
/// 静的配列
/// </summary>
namespace _0203_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列の宣言
            int[] values = new int[3];

            // 要素は0からスタート
            values[0] = 10;
            values[1] = 20;
            values[2] = 30;

            // 正しくできているか確認
            Console.WriteLine($"{values[0]},{values[1]},{values[2]}");

            // 配列の要素数
            Console.WriteLine($"{values.Length}");
        }
    }
}
