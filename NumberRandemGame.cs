using System;

namespace Program;

class Program
{
    static void Main()
    {
        int rundomInt;//随机的数字
        int insertNumber;//输入随机的数字
        int chanceCount = 7;//机会次数
        string startOrStop;//开始或结束游戏
        Random random = new Random();//开随机数字
        
        Console.Clear();
        Console.WriteLine("=== 数字猜谜游戏 ===");
        Console.WriteLine("规则：");
        Console.WriteLine("从0-100之间猜数字，共有7次机会");
        Console.WriteLine("准备好了吗？那开始吧（按y开始，否则退出程序）");
        startOrStop = Console.ReadLine();
        
        while (startOrStop == "y" || startOrStop == "Y")
        {
            rundomInt = random.Next(0, 101);
            while (chanceCount <= 7 && chanceCount != 0)
            {
                Console.WriteLine($"请猜数字（还剩{chanceCount}次机会）：");
                insertNumber = Convert.ToInt32(Console.ReadLine());
                
                if (insertNumber == rundomInt)
                {
                    Console.WriteLine($"猜对了！（还剩{chanceCount}次机会）");
                    break;
                }

                if (insertNumber > rundomInt)
                {
                    Console.WriteLine("太大了！");
                    chanceCount--;
                    continue;
                }

                if (insertNumber < rundomInt)
                {
                    Console.WriteLine("太小了！");
                    chanceCount--;
                }
            }

            if (chanceCount == 0)
            {
                Console.WriteLine("机会已用完，很遗憾");
            }
            Console.WriteLine("还要再猜一遍吗？（填y或n）");
            startOrStop = Console.ReadLine();
            chanceCount = 7;
        }
    }
}