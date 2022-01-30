using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.d
{
    class WeeklyReports
    {

        public int NumberofRecipients { get; set; }

        public int TheAmountOfMoneyEarned { get; set; }

        public int TheNumberOfVegetablesThrownAway { get; set; }

        public int CurrentRating { get; set; }


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();


        public WeeklyReports(int numberofRecipients, int theAmountOfMoneyEarned, int theNumberOfVegetablesThrownAway, int currentRating)
        {

            NumberofRecipients = numberofRecipients;

            TheAmountOfMoneyEarned = theAmountOfMoneyEarned;

            TheNumberOfVegetablesThrownAway = theNumberOfVegetablesThrownAway;

            CurrentRating = currentRating;

        }


        public void JsonSerialize(WeeklyReports arr)
        {

            WeeklyReports[] Weekly = new WeeklyReports[] { arr };

            var str = JsonConvert.SerializeObject(Weekly, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("WeeklyReports.json", str);

        }


        public void JsonDeserialize()
        {

            WeeklyReports[] Weekly = null;

            var jsonStr = File.ReadAllText("WeeklyReports.json");

            Weekly = JsonConvert.DeserializeObject<WeeklyReports[]>(jsonStr);

            player.URL = @"C:\Users\LITHIUM\Desktop\C# Finall\ConsoleApp1\ConsoleApp1\bin\Debug\net5.0\Notification.mp3";

            player.controls.play();
            Thread.Sleep(1050);
            player.controls.play();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t     Weekly Reports\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();


            foreach (var item in Weekly)
            {
                Console.WriteLine($"\n     Number of Recipients : {item.NumberofRecipients}\n     The amount of money earned : {item.TheAmountOfMoneyEarned} $\n     The number of vegetables thrown away : {item.TheNumberOfVegetablesThrownAway}\n     Current Rating : {item.CurrentRating} %\n");
            }

            Thread.Sleep(10000);
            
        }

    }

}
