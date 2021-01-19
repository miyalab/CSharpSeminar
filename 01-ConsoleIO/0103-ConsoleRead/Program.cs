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
            // 昔はASCIIコードしかなかった．126種類の文字
            char c;                 // 8 bit
            int inputChar;          // 32 bit
            string inputString;     // 16 x 文字数 bit

            // １行入力
            inputString = Console.ReadLine();
            Console.WriteLine(inputString);

            // １文字入力
            inputChar = Console.Read();
            Console.WriteLine((char)inputChar);
        }
    }
}
