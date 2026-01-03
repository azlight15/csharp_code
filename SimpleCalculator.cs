using System;

namespace Program;

class Program
{
    static double _number1, _number2;//两个数字
    static char _choice;
    static bool _running = true;
    
    static void DisplayMenu()//系统界面
    {
        Console.WriteLine("==================");
        Console.WriteLine("简易计算器");
        Console.WriteLine("操作步骤：");
        Console.WriteLine("1.选择运算方式（加、减、乘、除、平方、平方根）");
        Console.WriteLine("2.输入两个数字");
        Console.WriteLine("==================");
    }

    static void UserChoice() //操作选项
    {
        Console.WriteLine("请输入运算方式：");
        _choice = Console.ReadKey().KeyChar;
    }

    static void Lingshi()
    {
        switch (_choice)
        {
            case '+':
                Console.WriteLine($"{_number1}+{_number2}={_number1 + _number2}");
                break;
            case '-':
                Console.WriteLine($"{_number1}-{_number2}={_number1 - _number2}");
                break;
            case '*':
                Console.WriteLine($"{_number1}*{_number2}={_number1 * _number2}");
                break;
            case '/':
                if (_number2 == 0)
                {
                    Console.WriteLine("除数不能为零！");
                }
                else
                {
                    Console.WriteLine($"{_number1}/{_number2}={_number1 / _number2}");
                }
                break;
            case '^':
                Console.WriteLine($"{_number1}^{_number2}={Math.Pow(_number1, _number2)}");
                break;
            case 's':
                Console.WriteLine($"sqrt{_number1}={Math.Sqrt(_number1)}");
                Console.WriteLine($"sqrt{_number2}={Math.Sqrt(_number2)}");
                break;
            default:
                Console.WriteLine("请输入正确的运算符！");
                break;
        }
    }

    static void GetNumber()//获取数字
    {
        Console.Write("\n请输入第一个数字：");
        _number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("\n请输入第二个数字：");
        _number2 = Convert.ToDouble(Console.ReadLine());
    }
    
    static void Main()
    {
        while (_running)
        {
            DisplayMenu();
            GetNumber();
            UserChoice();
            Lingshi();
            Console.WriteLine("还要继续计算吗？（继续打y，其余的直接退出程序）");
            char jixu = Console.ReadKey().KeyChar;
            if (jixu == 'y')
            {
                _running = true;
            }
            else
            {
                _running = false;
            }
        }
    }
}