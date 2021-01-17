using System;

/// <summary>
/// コンソールの文字列入力プログラム
/// </summary>
namespace _03_ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputChar;
            string inputString;

            // １行入力
            inputString = Console.ReadLine();
            Console.WriteLine(inputString);

            // １文字入力
            inputChar = Console.Read();
            Console.WriteLine((char)inputChar);
        }
    }
}
