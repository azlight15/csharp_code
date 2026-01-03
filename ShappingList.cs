using System;

namespace Program;

class Program
{
    static void Main()
    {
        int i;
        string[] productName = new string[5];//商品名称

        Console.Clear();
        Console.WriteLine("===== 欢迎使用购物清单管理器 =====");
        Console.WriteLine("点击开始输入商品名称");
        Console.ReadKey();

        for (i = 0; i < productName.Length; i++)
        {
            Console.WriteLine($"输入第{i + 1}个商品名称");
            productName[i] = Console.ReadLine();
        }

        Console.WriteLine("您的购物清单：");
        foreach (string huh in productName)
        {
            Console.WriteLine(huh);
        }
    }
}