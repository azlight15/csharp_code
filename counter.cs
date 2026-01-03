/*简易计算器
项目要求：
创建控制台应用程序
显示操作选项菜单：
加法
减法
乘法
除法
用户选择操作后，输入两个数字
根据选择执行相应计算
需要考虑除法中除数为0的情况
计算完成后询问是否继续*/
using System;

class Program
{
    static void Main()
    {
        double num1;
        double num2;
        char str;
        
        Console.Clear();
        Console.WriteLine("简易计算器");
        Console.WriteLine("===================");
        Console.WriteLine("请输入第一个数字：");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入第二个数字：");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入运算符：");
        str = Console.ReadKey();

        switch (str)
        {
            case '+':
                Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("除数必须大于0！");
                    break;
                }
                else
                {
                    Console.WriteLine($"{num1}/{num2}={num1 / num2}");
                    break;
                }
        }
    }
}