using System;

/// <summary>
/// 数値を扱う変数
/// </summary>
namespace _0201_NumericVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 以下，数値を扱う変数
            sbyte sb;       // 符号付き 8 bit 整数型
            byte ub;        // 符号無し 8 bit 整数型

            short ss;       // 符号付き 16 bit 整数型
            ushort us;      // 符号無し 16 bit 整数型

            int si;         // 符号付き 32 bit 整数型
            uint ui;        // 符号無し 32 bit 整数型

            long sl;        // 符号付き 64 bit 整数型
            ulong ul;       // 符号無し 64 bit 整数型

            float f;        // 32 bit 実数型
            double d;       // 64 bit 実数型
            decimal dec;    // 128 bit 実数型

            // long型でFull HD 画質
            // 1920 x 1080 x 4 x 8 byte = 66,355,200 byte = 66 MB データサイズが大きい

            // byte型でFull HD 画質
            // 1920 x 1080 x 4 x 1 byte = 8,294,400 byte = 8 MB データサイズが小さい

            // コンパイルエラー
            //sb = -10.12;    // 整数型は実数を扱えない
            //ub = -10.12;    // 整数型は実数を扱えない
            //ss = -10.12;    // 整数型は実数を扱えない
            //us = -10.12;    // 整数型は実数を扱えない
            //si = -10.12;    // 整数型は実数を扱えない
            //ui = -10.12;    // 整数型は実数を扱えない
            //sl = -10.12;    // 整数型は実数を扱えない
            //ul = -10.12;    // 整数型は実数を扱えない
            //f = -10.12;     // -10.12 は double型なので保存できない
            //d = -10.12;
            //dec = -10.12;   // -10.12 は double型なので保存できない

            // castを付けて，変数型を変える
            sb = (sbyte)-10.12;
            //ub = (byte)-10.12;      // 符号なしは負の数を扱えない
            ss = (short)-10.12;
            //us = (ushort)-10.12;    // 符号なしは負の数を扱えない
            si = (int)-10.12;
            //ui = (uint)-10.12;      // 符号なしは負の数を扱えない
            sl = (long)-10.12;
            //ul = (ulong)-10.12;     // 符号なしは負の数を扱えない
            f = (float)-10.12;
            d = -10.12;
            dec = (decimal)-10.12;

            // データの表示
            Console.WriteLine($"{sb}");
            Console.WriteLine($"{ss}");
            Console.WriteLine($"{si}");
            Console.WriteLine($"{sl}");
            Console.WriteLine($"{f}");
            Console.WriteLine($"{d}");
            Console.WriteLine($"{dec}");

        }
    }
}
