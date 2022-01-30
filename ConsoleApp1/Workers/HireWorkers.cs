using ConsoleApp1.Cleaning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Workers
{
    class HireWorkers
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int WorkerFee { get; set; }

        static HireWorkers[] WorkerArray;

        public HireWorkers(string name, string surname, int age, int studyFee)
        {

            Name = name;
            Surname = surname;
            Age = age;
            WorkerFee = studyFee;

        }

        public HireWorkers() { }

        public void Hire()
        {

            Random rd = new Random();

            string randomName, randomSurname;
            int randomAge, randomStudyFee;

            string[] name = new string[]{ "James", "Robert", "John", "Michael", "William", "David",
                                          "Richard", "Joseph", "Thomas", "Charles", "Christopher",
                                          "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven",
                                          "Paul", "Andrew", "Joshua", "Kenneth", "Kevin", "Brian"};

            string[] surname = new string[] { "Smith", "Jones", "Taylor", "Williams", "Brown", "White",
                                              "Harris", "Martin", "Davies", "Wilson", "Cooper", "Evans",
                                              "King", "Thomas", "Baker", "Wright", "Johnson", "Edwards",
                                              "Collins ", "Moore", "Thompson", "James", "Walker"};


            string[] gender = new string[] { "Male", "Woman" };


            int randomSelection = rd.Next(0, name.Length);

            randomName = name[randomSelection];

            randomSurname = surname[randomSelection];

            randomAge = rd.Next(18,30);

            randomStudyFee = rd.Next(100, 150);

            HireWorkers newWorker = new(randomName,randomSurname,randomAge,randomStudyFee);


            WorkerArray = new HireWorkers[]
            {

                newWorker

            };

            Show();
        }

        

        public void Show()
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t     New worker is taken\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.ResetColor();



            foreach (var item in WorkerArray)
            {
                Console.WriteLine($"\n\t     Name : {item.Name}\n\t     Surname : {item.Surname}\n\t     Age : {item.Age}\n\t     StudyFee : {item.WorkerFee} $\n\n");
                Thread.Sleep(2000);
            }



            Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - |\n");

        }



        public int ReturnWorkerFee() { return WorkerArray[0].WorkerFee; }
    }
}
