using Menu.Vegetables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Budget
{
    class BudgetClass
    {



        public int Budget { get; set; }



        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();




        public void BudgetReduction(int weight, int value, ref int money)
        {

            if(money <= 0)
            {

                Console.Clear();

                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\GameOver.mp3";

                player.controls.play();
                Thread.Sleep(5050);
                player.controls.stop();

            }
            else
            {

                money -= (weight * value);

                Budget = money;

            }
        }


        public void BudgetIncrease(ref int money, int value) { money += value; }


        public void WorkerMonthlyWage(ref int money, int value)
        {

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";


            player.controls.play();
            Thread.Sleep(1050);
            player.controls.stop();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tThe employee is paid weekly\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();


            Console.WriteLine("\t     Budget : " + money + "\n\t     Worker Fee : " + value + " $" + "\n\t     ");
            
            money -= value;
            
            Console.WriteLine("\t     Budget After : " + money);

            Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");

            Thread.Sleep(10000);

        }


        public void WorkerMonthlyWageTwo(ref int money, int value)
        {

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";


            player.controls.play();
            Thread.Sleep(1050);
            player.controls.stop();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t  Bankrupt Labor Rights\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();


            Console.WriteLine("\t     Budget : " + money + "\n\t     Worker Fee : " + value + "\n\t     ");
            
            money -= value;
            
            Console.WriteLine("\t     Budget After : " + money);

            Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");

            Thread.Sleep(10000);

        }
    }
}
