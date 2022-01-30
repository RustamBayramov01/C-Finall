using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp1.Rating;
using System.Threading.Tasks;
using System.Threading;
using Menu.Vegetables;
using ConsoleApp1.Budget;
using ConsoleApp1.Daily;
using ConsoleApp1.Cleaning;
using ConsoleApp1.Workers;
using ConsoleApp1.Epidemic;
using ConsoleApp1.d;
using ConsoleApp1.EventAging;

namespace ConsoleApp1.Buyers
{
    class BuyersQU
    { 

        int Day = 1, SevenDaysEarning = 0, Size = 0;

        int numberOfBuyers = 0, theAmountOfMoneyEarned = 0, theNumberOfVegetablesThrownAway = 0, currentRating = 0;



        static bool pathOne = false;

        static int EpidemicSize = 0;



        Aging aging;

        VegetablesClass VC;

        BudgetClass budget;

        WeeklyReports weeklyReports;



        EpidemicClass epidemic = new();

        HireWorkers Hworker = new();

        ToWork toWork = new();

        Queue buyersQU = new();

        DailyEarnings daily = new();

        CleaningStick cStick = new();

        RatingLevel ratingLevel = new();



        public int BuyersSize { get; set; } = 0;



        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();


        public void ddd() { pathOne = true; }


        public void Buyers(Dictionary<object,object> vegetables, int size)
        {

            Console.Clear();

            int Kg = 0 , loop = 0 , value = 0 , RandomSize = 0 , selectionSize = 0;

            int RandomToxic = 0;

            string Key = "";

            Random random = new Random();

            budget = new();

            VC = new();


            int otherSize = BuyersSize;
            ratingLevel.Rating(ref otherSize);
            BuyersSize = otherSize;


            if (pathOne == true)
            {

                EpidemicSize++;

                if (EpidemicSize == 14) // 7
                {
                    player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

                    player.controls.play();
                    Thread.Sleep(1050);
                    player.controls.stop();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t     The epidemic is over !\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - |\n");
                    Console.ResetColor();


                    pathOne = false;
                    EpidemicSize = 0;

                }
            }



            if (pathOne == false)
            {

                for (int i = 0; i < BuyersSize; i++) 
                {

                    numberOfBuyers++;
                    buyersQU.Enqueue(i + 1);

                }
                
            }



            if(pathOne == false)
            {
                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

                Console.WriteLine("| - - - - - - Zebzes are coming - - - - - - |");
                Console.WriteLine();
                
                Thread.Sleep(1000);
                
                foreach (var item in vegetables) Console.WriteLine("\t     " + item.Key + "   " + item.Value);
                Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");
            }






            if(pathOne == false)
            {

                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";
                Console.WriteLine("\n\t     Customer Size : " + buyersQU.Count + "\n");
                Thread.Sleep(2000);
                player.controls.play();
                Thread.Sleep(500);
                player.controls.stop();
                Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");

            }



            if (pathOne == false)
            {

                for (int i = 0; i < otherSize; i++)
                {

                    int randomBuyersVoice = random.Next(1, 6);

                    loop = random.Next(1, 3);

                    Console.WriteLine($"\n\t     Customer : {buyersQU.Count}\n");

                    Console.WriteLine("\t     How many will she buy : " + loop);

                    Thread.Sleep(2000);

                    switch (randomBuyersVoice)
                    {
                        case 1:
                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Hmm1.mp3";
                            player.controls.play();
                            Thread.Sleep(9000);
                            player.controls.stop();
                            break;
                        case 2:
                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Hmm2.mp3";
                            player.controls.play();
                            Thread.Sleep(2000);
                            player.controls.stop();
                            break;
                        case 3:
                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Hmm3.mp3";
                            player.controls.play();
                            Thread.Sleep(3500);
                            player.controls.stop();
                            break;
                        case 4:
                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Hmm4.mp3";
                            player.controls.play();
                            Thread.Sleep(10000);
                            player.controls.stop();
                            break;
                        case 5:
                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Hmm5.mp3";
                            player.controls.play();
                            Thread.Sleep(2500);
                            player.controls.stop();
                            break;

                    }

                    for (int j = 0; j < loop; j++)
                    {

                        RandomSize = random.Next(1, (size * 2));

                        RandomToxic = random.Next(1, 20);

                        Kg = random.Next(1, 3);



                        if (RandomToxic == 8)
                        {

                            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Toxic.mp3";

                            player.controls.play();
                            Thread.Sleep(4050);
                            player.controls.stop();

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t     Toxic fruit found\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
                            Console.ResetColor();

                            ratingLevel.EvaluationControl(2);
                            Thread.Sleep(3000);
                            break;

                        }
                        else
                        {

                            foreach (var item in vegetables)
                            {

                                selectionSize++;

                                if (RandomSize == selectionSize)
                                {
                                    player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\ParaAlmaSesi.mp3";

                                    Console.WriteLine("\t     Selection : " + selectionSize);
                                    Console.WriteLine("\t     Kg : " + Kg + "\n");

                                    player.controls.play();
                                    Thread.Sleep(1200);
                                    player.controls.stop();

                                    Key = (string)item.Key;

                                    value = (int)item.Value;

                                    if ((value - Kg) <= 0)
                                    {

                                        ratingLevel.EvaluationControl(1);
                                        selectionSize = 0;
                                        break;

                                    }
                                    else
                                    {

                                        SevenDaysEarning += 25;
                                        theAmountOfMoneyEarned += 25;
                                        VC.PathBudgetIncrease(25);
                                        vegetables[Key] = value - Kg;
                                        selectionSize = 0;
                                        break;

                                    }

                                }
                            }
                        }

                    }


                    if (pathOne == false) buyersQU.Dequeue();

                    cStick.StickIncrease();

                }
            }


            
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t     At the end of the day\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();

            foreach (var item in vegetables) Console.WriteLine("\t     " + item.Key + "   " + item.Value);
            Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";
           
            player.controls.play();
            Thread.Sleep(1000);
            player.controls.stop();

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Score.mp3";

            Console.ForegroundColor = ConsoleColor.Yellow;
            player.controls.play();
            Thread.Sleep(1050);
            Console.WriteLine(ratingLevel.ToString());
            player.controls.stop();
            Console.ResetColor();
            Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - |\n");


            Thread.Sleep(3000);


            cStick.StickControl();



            if (Day == 7)
            {

                int other = random.Next(1, 10);

                if (other == 3)
                {

                    cStick.Resigned();
                    int money = Hworker.ReturnWorkerFee();
                    VC.BankruptLaborRights(money);

                }

            }




            bool control = cStick.workerFoundd();




            if (Day == 7)
            {

                if (control == true)
                {

                    int money = Hworker.ReturnWorkerFee();

                    VC.WorkerFee(money);

                }

                currentRating = ratingLevel.ReturnRatinBar();


                int other = 0;
                foreach (var item in vegetables)
                {

                    other++;
                    
                    if(other > size) theNumberOfVegetablesThrownAway += (int)item.Value;

                }


                weeklyReports = new(numberOfBuyers, theAmountOfMoneyEarned, theNumberOfVegetablesThrownAway, currentRating);

                weeklyReports.JsonSerialize(weeklyReports);

                weeklyReports.JsonDeserialize();

                VC.Pathh(SevenDaysEarning);

                VC.RandomNameAndValue(ref vegetables);

            } 
            else
            {
                
                if(pathOne == false)
                {

                    if (control == true)
                    {
                        player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

                        player.controls.play();
                        Thread.Sleep(500);
                        player.controls.stop();

                        toWork.DilyIncrease();
                    }
                    ratingLevel.EvaluationControlTwo(3);

                }



                Day++;
                Size = size;
                
                

                if(pathOne == false) epidemic.EpidemicIncrease();



                Thread.Sleep(1000);

                Buyers(vegetables, Size);
            }

        }

    }
}
