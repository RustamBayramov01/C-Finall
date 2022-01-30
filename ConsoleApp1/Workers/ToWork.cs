using ConsoleApp1.Cleaning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Workers
{

    class ToWork
    {


        CleaningStick Cstick = new();

    

        public void DilyIncrease()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tThe vegetable market is cleaned\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();

            Thread.Sleep(1000);
            Cstick.StickReduction();

        }

    }

}
