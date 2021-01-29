using System;

/// <summary>
/// 文字を扱う変数
/// </summary>
namespace _0202_StringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;         // 1文字だけ保存できる
            string s;       // 1文字以上保存できる

            //c = "seminar";    // 1文字じゃないのでエラー
            c = 's';            // 1文字を' 'で囲む
            s = "seminar";      // 1文字以上を" "で囲む

            Console.WriteLine($"{c}");
            Console.WriteLine($"{s}");

            // string型の特定の文字にアクセス
            Console.WriteLine($"sの2文字目：{s[1]}");

            // string型の文字数
            Console.WriteLine($"sの文字の長さ：{s.Length}");

            // string型の文字列を特定の文字で分割
            string[] split = s.Split("i");
            Console.WriteLine($"{split[0]},{split[1]}");
        }
    }
}
