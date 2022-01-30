using ConsoleApp1.Buyers;
using ConsoleApp1.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Epidemic
{
    class EpidemicClass
    {


        BuyersQU buyersQU;


        static int EpidemicDay = 0;


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();



        public void EpidemicIncrease()
        {

            EpidemicDay++;
            
            if(EpidemicDay == 20) // 20
            {
                
                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\PantemicSound.mp3";


                player.controls.play();
                Thread.Sleep(7000);
                player.controls.stop();


                player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";


                player.controls.play();
                Thread.Sleep(1000);
                player.controls.stop();


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tEpidemic Has Begun !\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
                Console.ResetColor();



                Thread.Sleep(3000);

                buyersQU = new();

                buyersQU.ddd();

                EpidemicDay = 0;

            }
        }
    }
}
