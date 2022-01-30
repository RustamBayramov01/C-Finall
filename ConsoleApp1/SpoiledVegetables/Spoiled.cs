using ConsoleApp1.EventAging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.SpoiledVegetables
{
    class Spoiled
    {



        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();




        public void Show(Dictionary<object,object> newArrivals, Dictionary<object, object> DictionaryList)
        {


            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";
            player.controls.play();
            Thread.Sleep(1000);
            player.controls.stop();



            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\YeniMalGetirende.mp3";
            player.controls.play();
            Thread.Sleep(18000);
            player.controls.stop();



            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";
            player.controls.play();
            Thread.Sleep(1000);
            player.controls.stop();


            Console.Clear();


            Console.WriteLine("- - - - - - - - - - New Arrivals - - - - - - - - - -");


            Console.WriteLine("\n\n------------------------");
            
            foreach (var item in newArrivals)
            {

                Console.Write(item.Key);
                Console.WriteLine($"\t\tKg : {item.Value}");
                Console.WriteLine("------------------------");

            }


            Console.WriteLine("\n");
            Console.WriteLine("- - - - - - - - - - - - Rotten - - - - - - - - - - - -");


            Console.WriteLine("\n\n------------------------");
            foreach (var item in DictionaryList)
            {

                Console.WriteLine(item.Key);
                Console.WriteLine($"\t\tKg : {item.Value}");
                Console.WriteLine("------------------------");

            }


            Thread.Sleep(5000);
            Console.Clear();
        }

    }
}
