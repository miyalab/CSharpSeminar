using System;

/// <summary>
/// 構造体
/// </summary>
namespace _0206_Struct
{
    /// <summary>
    /// 構造体の定義
    /// </summary>
    struct Human{
        public string name;
        public int age;
        public int birthday;
    }

    /// <summary>
    /// クラス定義
    /// </summary>
    class Hito{
        public string name;
        public int age;
        public int birthday;
    }

    class Program
    {   
        static void Main(string[] args)
        {
            Human student;                  // 構造体の用意
            Hito student2 = new Hito();     // クラスの用意

            student.name = "Yamada";
            student.age = 22;
            student.birthday = 19970404;

            student2.name = "Sato";
            student2.age = 21;
            student2.birthday = 19980102;

            Console.WriteLine(student.name);
            Console.WriteLine();
            Console.WriteLine(student2.name);
        }
    }
}
