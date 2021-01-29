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
            // 動的配列の宣言
            List<int> values = new List<int>();

            // Listの要素数
            Console.WriteLine($"{values.Count}");

            // Listに要素を追加
            values.Add(10);
            values.Add(20);
            values.Add(30);

            // 正しくできているか確認
            Console.WriteLine($"要素数：{values.Count}");                   // Listの要素数
            Console.WriteLine($"{values[0]},{values[1]},{values[2]}");     // 中身の表示

            // 要素の挿入
            values.Insert(2, 20);
            Console.WriteLine($"要素数：{values.Count}");                               // Listの要素数
            Console.WriteLine($"{values[0]},{values[1]},{values[2]},{values[3]}");     // 中身の表示

            // 要素を削除 その1
            values.RemoveAt(0);
            Console.WriteLine($"要素数：{values.Count}");                   // Listの要素数
            Console.WriteLine($"{values[0]},{values[1]},{values[2]}");     // 中身の表示

            // 要素を削除 その2
            values.Remove(20);
            Console.WriteLine($"要素数：{values.Count}");                   // Listの要素数
            Console.WriteLine($"{values[0]},{values[1]}");                 // 中身の表示
        }
    }
}
