using ConsoleApp1.Rating;
using Menu.Vegetables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Daily
{
    class DailyEarnings
    {

        VegetablesClass VC = new();
        RatingLevel ratingLevel = new();

        public void Earnings(int value, ref int max)
        {

            int budget = VC.BudgetReturn();

            int result = (budget * 10) / 100;

            Console.WriteLine($"\n     Seven Days Earning : {value} $\n");

            Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - |\n");



            if (value > result) max += 5;



            int rating = ratingLevel.ReturnRatinBar();



            if (rating <= 30) ratingLevel.EvaluationControlTwo(30);



            Thread.Sleep(20000);

        }

    }

}
