using System;
using System.Collections.Generic;

/// <summary>
/// Listを使用した動的配列
/// </summary>
namespace _0204_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            
            // Listの要素数
            Console.WriteLine($"{values.Count}");

            // Listに要素を追加
            values.Add(10);
            values.Add(20);
            values.Add(30);

            // 正しくできているか確認
            Console.WriteLine($"{values[0]},{values[1]},{values[2]}");

            // 配列の要素数
            Console.WriteLine($"{values.Count}");
        }
    }
}
