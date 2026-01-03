using System;

class Program
{
    static int healthPoints = 100;//生命值
    static int magicPower = 50;//魔法值
    static int powerRating;//实力值
    static int energyPoints = 100;//精力值
    static int options;//选项
    static bool game = true;

    static void loadingGame()
    {
        Console.WriteLine("按下任意键回到主页面...");
        Console.ReadLine();
    }
    
    static void hit()
    {
        if (healthPoints >= 10 && energyPoints >= 10)//血条充足
        {
            Console.WriteLine("选择攻击方式（物理/魔法）："); 
            string hitOptions = Console.ReadLine();//hitChoice:攻击选项
            while (hitOptions != "物理" && hitOptions != "魔法")//选择不正确攻击方式
            {
                Console.WriteLine("请重新选择攻击方式（物理/魔法）：");
                hitOptions = Console.ReadLine();
            }

            if (hitOptions == "物理")//物理攻击
            {
                powerRating += 5;
                healthPoints -= 3;
                Console.WriteLine("攻击敌人5点！自身实力上涨5点！生命值扣除3点！");
                loadingGame();
            }
            else//魔法攻击
            {
                if (magicPower > 0)//魔法充足
                {
                    powerRating += 10;
                    magicPower -= 5;
                    Console.WriteLine("攻击敌人10点！，自身实力上涨10点！魔法值扣除5点！");
                    loadingGame();
                }
                else//不充足
                {
                    Console.WriteLine("魔法值不足，请回去治疗");
                    loadingGame();
                }
            }
        }
        else
        {
            if (healthPoints < 10)//血条不足
            {
                Console.WriteLine("血条不足，请回去治疗");
            }
                        
            if (energyPoints < 10)//精力不足
            {
                Console.WriteLine("精力不足，请回去治疗");
            }
                        
            loadingGame(); 
        }
    }

    static void cure()
    {
        Console.WriteLine("选择治疗选项（生命/魔法）：");
        string cureOptions = Console.ReadLine();//cureChoice:治疗选项
        while (cureOptions != "生命" && cureOptions != "魔法")//选择不正确治疗方式
        {
            Console.WriteLine("请重新选择治疗方式（生命/魔法）：");
            cureOptions = Console.ReadLine();
        }

        if (cureOptions == "生命")//治疗生命
        {
            healthPoints += 50;
            Console.WriteLine("生命已恢复50点");
            loadingGame();
        }
        else
        {
            magicPower += 25;
            Console.WriteLine("魔法值已恢复25点");
            loadingGame();
        }
    }

    static void rest()
    {
        if (healthPoints <= 250 || magicPower <= 100)
        {
            healthPoints += 100;
            magicPower += 50;
            Console.WriteLine("休息结束，您的生命增加了100点，魔法值增加了50点");
            loadingGame();
        }
        else
        {
            Console.WriteLine("您的各项数值非常充足，可以继续攻击敌人");
            loadingGame();
        }
    }

    static void status()
    {
        Console.WriteLine("当前状态：");
        Console.WriteLine($"生命值：{healthPoints}");
        Console.WriteLine($"魔法值：{magicPower}");
        Console.WriteLine($"实力值：{powerRating}");
        Console.WriteLine($"精力值：{energyPoints}");
        Console.WriteLine("===============");
        loadingGame();
    }

    static void exitGame()
    {
        Console.WriteLine("感谢您能玩这个游戏:)");
        Console.WriteLine("输入任意键离开游戏...");
        Console.ReadKey();
        game = false;
    }
    
    static void Main()
    {
        while (game)
        {
            Console.Clear();
            Console.WriteLine("===== 简单的游戏:) =====");
            Console.WriteLine("===== 菜单选项 =====");
            Console.WriteLine("1.攻击");
            Console.WriteLine("2.治疗");
            Console.WriteLine("3.休息");
            Console.WriteLine("4.查看状态");
            Console.WriteLine("5.退出游戏");
        
            Console.Write("\n请选择选项（1-5）：");
            options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1://攻击敌人
                    Console.Clear();
                    hit();
                    break;
                case 2://治疗
                    Console.Clear();
                    cure();
                    break;
                case 3://休息
                    Console.Clear();
                    rest();
                    break;
                case 4://查看状态
                    Console.Clear();
                    status();
                    break;
                case 5://退出游戏
                    Console.Clear();
                    exitGame();
                    break;
                default:
                    Console.WriteLine("输入错误，请重新输入选项（1-4）：");
                    options = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
    }
}