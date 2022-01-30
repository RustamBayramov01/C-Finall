using ConsoleApp1.Buyers;
using ConsoleApp1.SpoiledVegetables;
using Menu.Vegetables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.EventAging
{
    class Aging
    {



        Spoiled spoiled = new();

        BuyersQU buyersQU = new();

        VegetablesClass VC = new();



        public int Count { get; set; } = 0;
        public int Remove { get; set; } = 5;
        public Aging(int count) { Count = count; }



        ArrayList otherLastArrKey = new ArrayList();

        ArrayList otherLastArrTwoKey = new ArrayList();

        ArrayList otherLastArrValue = new ArrayList();

        ArrayList otherLastArrTwoValue = new ArrayList();



        Dictionary<object, object> ToSort = new Dictionary<object, object>();



        public void AgingE(ref Dictionary<object,object> Fresh , ref Dictionary<object, object> Normal)
        {

            if (Count == 2)
            {

                foreach (var item in Fresh) ToSort.Add(item.Key, item.Value); 
                
                foreach (var item in Normal) ToSort.Add("Normal " + item.Key, item.Value); 

                buyersQU.Buyers(ToSort,Remove);

            }
            else if (Count >= 3)
            {

                foreach (var item in Normal) otherLastArrKey.Add(item.Key); 
                foreach (var item in Normal) otherLastArrValue.Add(item.Value);


                for (int i = 0; i < Remove; i++) otherLastArrTwoKey.Add(otherLastArrKey[i]);        
                for (int i = 0; i < Remove; i++) otherLastArrTwoValue.Add(otherLastArrValue[i]);


                Normal.Clear();


                for (int i = 0; i < otherLastArrTwoKey.Count; i++) Normal.Add(otherLastArrTwoKey[i], otherLastArrTwoValue[i]);


                foreach (var item in Fresh) ToSort.Add(item.Key, item.Value);

                
                foreach (var item in Normal) ToSort.Add("Normal " + item.Key, item.Value);


                spoiled.Show(Fresh,Normal);


                buyersQU.Buyers(ToSort,Remove);

            }
        }
    }
}
