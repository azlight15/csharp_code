using System;

namespace Program;

class Program
{
    static bool _run = true;//系统的启动与关闭

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("===== 乘法表生成器 =====");
        Console.WriteLine("1.显示标准九九乘法表");
        Console.WriteLine("2.生成指定数字乘法表");
        Console.WriteLine("3.生成指定范围乘法表");
        Console.WriteLine("4.显示金字塔型乘法表");
        Console.WriteLine("5.退出");
        Console.WriteLine("======================");
    }
    
    static void TheNineTimesTable()//九九乘法表
    {
        int i, j;
        
        for (i = 1; i <= 9; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write($"{j} * {i} = {j * i}  ");
            }

            Console.Write("\n");
        }

        Loading();
    }

    static void SpecifiedMultiplicationTables()//指定数字乘法表
    {
        int insertNumbers, fixedNumbers;
        
        Console.WriteLine("请输入1-20的数字：");
        insertNumbers = Convert.ToInt32(Console.ReadLine());

        while (insertNumbers < 1 || insertNumbers > 20)
        {
            Console.WriteLine("输入错误，请重新输入1-20的数字：");
            insertNumbers = Convert.ToInt32(Console.ReadLine());
        }

        for (fixedNumbers = 1; fixedNumbers <= 20; fixedNumbers++)
        {
            Console.WriteLine($"{insertNumbers} * {fixedNumbers} = {insertNumbers * fixedNumbers}");
        }

        Loading();
    }

    static void MultiplicationTablesForSpecifiedRanges()//指定范围乘法表
    {
        int startNumbers, endNumbers;//起始数字和终点数字
        int m, n;//临时变量

        Console.WriteLine("请输入起始数字：");
        startNumbers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("请输入结束数字：");
        endNumbers = Convert.ToInt32(Console.ReadLine());

        for (m = startNumbers; m <= endNumbers; m++)
        {
            for (n = startNumbers; n <= endNumbers; n++)
            {
                Console.Write($"{n} * {m} = {n * m}  ");
            }

            Console.Write("\n");
        }

        Loading();
    }

    static void Pyramid_shapedMultiplicationTables()//金字塔型乘法表
    {
        int insertNumber;
        int x, y;

        Console.WriteLine("请输入数字：");
        insertNumber = Convert.ToInt32(Console.ReadLine());

        for (x = 1; x <= insertNumber; x++)
        {
            for (y = 1; y <= x; y++)
            {
                Console.Write(y * x);
            }

            Console.Write("\n");
        }

        Loading();
    }

    static void Exit()//退出
    {
        Console.WriteLine("感谢使用！");
        Loading();
        _run = false;
    }

    static void Loading()
    {
        Console.WriteLine("按下任意键回到主页面...");
        Console.ReadKey();
    }
    
    static void Main()
    {
        int options;//总选项变量

        do
        {
            Menu();
            Console.WriteLine("请选择选项（1-5）：");
            options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:
                    TheNineTimesTable();
                    break;
                case 2:
                    SpecifiedMultiplicationTables();
                    break;
                case 3:
                    MultiplicationTablesForSpecifiedRanges();
                    break;
                case 4:
                    Pyramid_shapedMultiplicationTables();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    while (options < 1 || options > 5)
                    {
                        Console.WriteLine("输入错误！请重新选择选项（1-5）：");
                        options = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
            }
        } while (_run);
        
    }
}