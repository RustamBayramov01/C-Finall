using ConsoleApp1.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Cleaning
{
    class CleaningStick
    {


        HireWorkers hireWorkers;


        public static bool worker = false;
        public static bool workerFound = false;
        public static int cleaningStickk = 0;


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();


        public bool workerFoundd() { return workerFound; }


        public void Resigned()
        {

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

            player.controls.play();
            Thread.Sleep(1050);
            player.controls.stop();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t     Worker resigned !\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();

            workerFound = false;

            Thread.Sleep(2000);

        }



        public void StickReduction()
        {

            while (cleaningStickk != 0) { cleaningStickk -= 1; }

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\TemizlemeSesi.mp3";

            player.controls.play();
            Thread.Sleep(3050);
            player.controls.stop();

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Okey.mp3";

            player.controls.play();
            Thread.Sleep(1050);
            player.controls.play();

            Console.WriteLine("\n");

        }


        public void StickIncrease()
        {

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

            cleaningStickk += 5;
            Console.WriteLine("\t     Cleaning Stick : " + cleaningStickk + "\n");

            player.controls.play();
            Thread.Sleep(500);
            player.controls.stop();

            Console.WriteLine("\n| - - - - - - - - - - - - - - - - - - - - - |\n");
            Thread.Sleep(500);

        }


        public void StickControl()
        {

            if (cleaningStickk >= 5) { worker = true; } // 70 olacaq
            
            if(worker == true && workerFound == false)
            {
                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

                player.controls.play();
                Thread.Sleep(500);
                player.controls.stop();

                workerFound = true;

                hireWorkers = new();
                hireWorkers.Hire();
            }

        }
    }
}
