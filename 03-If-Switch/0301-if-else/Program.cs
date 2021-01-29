using System;

/// <summary>
/// if else 条件分岐処理
/// </summary>
namespace _0301_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str;

            // データの入力
            str = Console.ReadLine();
            num = int.Parse(str);

            // 条件分岐処理
            if(num < 100)
            {
                Console.WriteLine("100 Under");
            }
            else if(num < 200)
            {
                Console.WriteLine("200 Under");
            }
            else
            {
                Console.WriteLine("200 Over");
            }
        }
    }
}
