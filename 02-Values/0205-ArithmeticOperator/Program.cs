using System;

/// <summary>
/// 算術演算子
/// </summary>
namespace _0205_ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 22;
            double c = 1412.2, d = 214.0;

            // 整数型演算
            Console.WriteLine(a + b);       // 加算
            Console.WriteLine(a - b);       // 減算
            Console.WriteLine(a * b);       // 乗算
            Console.WriteLine(a / b);       // 除算
            Console.WriteLine(a % b);       // 剰余算
            Console.WriteLine();

            // 実数型演算
            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
            Console.WriteLine(c % d);
            Console.WriteLine();

            // 数学定数
            Console.WriteLine(Math.PI);         // 円周率
            Console.WriteLine(Math.E);          // ネイピア数
            Console.WriteLine();

            // 指数関数・対数関数
            Console.WriteLine(Math.Log(c));     // 自然対数
            Console.WriteLine(Math.Log10(c));   // 常用対数
            Console.WriteLine(Math.Log2(c));    // 底2の対数
            Console.WriteLine(Math.Pow(a, b));  // aのb乗
            Console.WriteLine(Math.Exp(b));     // eのb乗
            Console.WriteLine();

            // 三角関数
            Console.WriteLine(Math.Sin(d));     // sin関数
            Console.WriteLine(Math.Cos(d));     // cos関数
            Console.WriteLine(Math.Tan(d));     // tan関数

        }
    }
}
