using System;

// switch case 条件分岐処理
namespace _0302_switch
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

            switch (num)
            {
                case 0:
                    Console.WriteLine(0);
                    break;

                case 1:
                    Console.WriteLine(1);
                    break;

                case 2:
                    Console.WriteLine(2);
                    break;

                case 3:
                    Console.WriteLine(3);
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
