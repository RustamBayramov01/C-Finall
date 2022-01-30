using ConsoleApp1.Budget;
using ConsoleApp1.Buyers;
using ConsoleApp1.Cleaning;
using ConsoleApp1.Daily;
using ConsoleApp1.EventAging;
using ConsoleApp1.Rating;
using ConsoleApp1.Workers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu.Vegetables
{

    class VegetablesClass
    {

        static int budgetT = 1000;

        public static int max = 20;

        public static int Loop = 1; 

        public static int RandomLoopSize { get; set; } = 5; // 5

        public int RandomValue { get; set; }

        public int Weight { get; set; }
        

        //

        RatingLevel ratingLevel = new();

        BudgetClass budget;

        DailyEarnings daily;

        Stack VegetablesName = new Stack();
        
        Stack VegetableValue = new Stack();

        Dictionary<object,object> Stend = new Dictionary<object, object>();

        Dictionary<object, object> StendCopy = new Dictionary<object, object>();



        string[] AllVegetables = new string[]
        {
            "Carrot",
            "Broccoli",
            "Green pepper",
            "Red pepper",
            "Tomato",
            "Potato",
            "Mushrooms",
            "Pumpkin",
            "Cucumber",
            "Radish"
        };



        int[] VegetablePrice = new int[10];

        public int BudgetReturn() { return budgetT; }

        public int ReturnRandomLoopSize() { return RandomLoopSize; }



        public void Pathh(int value)
        {
            daily = new();
            daily.Earnings(value, ref max);
        }




        public void PathBudgetIncrease(int value)
        {
            budget = new();
            budget.BudgetIncrease(ref budgetT, value);
        }




        public void WorkerFee(int value)
        {
            budget = new();
            budget.WorkerMonthlyWage(ref budgetT, value);
        }




        public void BankruptLaborRights(int value)
        {
            budget = new();
            budget.WorkerMonthlyWageTwo(ref budgetT, value);
        }




        public void Path(Dictionary<object, object> Teze, Dictionary<object, object> Kohne)
        {

            Aging aging = new(Loop);
            aging.Remove = RandomLoopSize;
            aging.AgingE(ref Teze, ref Kohne);
           
        }



        public void RandomSizeAndRating()
        {

            int other = ratingLevel.ReturnRatinBar();
        
            if (other >= 51 && other < 60) RandomLoopSize = 6;

            else if (other >= 60 && other < 70) RandomLoopSize = 7;

            else if (other >= 70 && other < 80) RandomLoopSize = 8;

            else if (other >= 80 && other < 90) RandomLoopSize = 9;

            else if (other >= 90) RandomLoopSize = 10;

            else RandomLoopSize = 5;
        
        }



        public void RandomNameAndValue(ref Dictionary<object, object> other)
        {


            budget = new();


            RandomSizeAndRating();


            Random random = new Random();


            var arlist = new ArrayList();



            for (int i = 0; i < RandomLoopSize; i++)
            {

                int dailyVegetablePrice = random.Next(1, 3);
                VegetablePrice[i] = dailyVegetablePrice;

            }



            for (int i = 0; i < RandomLoopSize; i++)
            {

                RandomValue = random.Next(0, AllVegetables.Count());
                Weight = random.Next(10, max);

                if (arlist.Contains(RandomValue))
                {

                    i--;

                    continue;

                }
                else
                {

                    arlist.Add(RandomValue);

                    VegetablesName.Push(AllVegetables[RandomValue]);

                    VegetableValue.Push(Weight);

                    budget.BudgetReduction(Weight, VegetablePrice[RandomValue], ref budgetT);

                    if (Loop == 1)
                    {

                        StendCopy.Add(VegetablesName.Peek(), VegetableValue.Peek());
                        Stend.Add(VegetablesName.Pop(), VegetableValue.Pop());

                    }
                    else if (Loop == 2)
                    {

                        StendCopy = other;
                        Stend.Add(VegetablesName.Pop(), VegetableValue.Pop());


                    }
                    else if (Loop >= 3)
                    {

                        StendCopy = other;                        
                        Stend.Add(VegetablesName.Pop(), VegetableValue.Pop());

                    }
                }
            }



            Loop++; 

            if(Loop >= 2) Path(Stend, StendCopy);

        }

    }

}
