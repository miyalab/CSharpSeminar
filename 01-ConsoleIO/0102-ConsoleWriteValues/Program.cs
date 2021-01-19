using System;

/// <summary>
/// コンソールの文字列出力プログラム（変数を用いる）
/// </summary>
namespace _02_ConsoleWriteValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2021;
            int month = 1;
            int day = 18;
            string week = "月";
            
            // 変数をそのまま表示
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(week);

            // 変数を参照して日付を表示 その1
            Console.WriteLine("{0}年{1}月{2}日{3}曜日", year, month, day, week);

            // 変数を参照して日付を表示 その2
            Console.WriteLine($"{year}年{month}月{day}日{week}曜日");
        }
    }
}
