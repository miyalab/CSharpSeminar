using System;

/// <summary>
/// コンソールの文字列入力プログラム
/// </summary>
namespace _04_ConsoleReadValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            // 整数入力
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"入力された数値：{num1}");

            // 空白区切り入力
            string[] data = Console.ReadLine().Split(' ');
            num1 = int.Parse(data[0]);
            num2 = int.Parse(data[1]);
            Console.WriteLine($"{num1} {num2}");
        }
    }
}
