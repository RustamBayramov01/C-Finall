using ConsoleApp1.Buyers;
using Menu.Vegetables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Rating
{
    class RatingLevel
    {
        
        public int LoopSize { get; set; }

        public static int RatingBar { get; set; } = 40; // 40

        public override string ToString() => $"\t     Rayting : {RatingBar} %\n";


        public int ReturnRatinBar() { return RatingBar; }

        public void EvaluationControl(int other) { RatingBar -= other; }

        public void EvaluationControlTwo(int other) { RatingBar += other; }



        public void Rating(ref int buyerSize)
        {

            if(RatingBar <= 0)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(0);

            }
            else if (RatingBar > 0 && RatingBar <= 10)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(1,5);

            }
            else if(RatingBar >= 10 && RatingBar <= 20)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(3, 10);

            }
            else if (RatingBar >= 20 && RatingBar <= 30)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(5, 15);

            }
            else if (RatingBar >= 30 && RatingBar <= 40)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(7, 18);

            }
            else if (RatingBar >= 40 && RatingBar <= 50)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(8, 20);

            }
            else if (RatingBar >= 50 && RatingBar <= 60)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(9, 22);

            }
            else if (RatingBar >= 60 && RatingBar <= 70)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(9, 25);

            }
            else if (RatingBar >= 70 && RatingBar <= 80)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(15, 30);

            }
            else if (RatingBar >= 80 && RatingBar <= 90)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(15, 30);

            }
            else if (RatingBar >= 90)
            {

                Random randomBuyersSize = new Random();

                buyerSize = randomBuyersSize.Next(20, 40);

            }
        }

    }
}
