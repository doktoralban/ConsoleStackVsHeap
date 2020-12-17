using System;

namespace ConsoleStackVsHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;string abc = "sabc";double dcf;
            //int i,string abc and double dcf -> "stack memory"
            //1,sabc -> "heap memory"

            //example; 
            string[] fruits = { "elma", "armut", "portakal" };
            string[] vegetables = { "patates", "patlıcan", "pırasa", "sarmısak" };
            //string[] fruits and string[] vegetables-> "stack memory"
            //{ "elma", "armut", "portakal" } and  { "patates", "patlıcan", "pırasa", "sarmısak" } -> "heap memory" 

            Console.WriteLine(string.Format( "fruit 0  ->  {0}  " , fruits[0]));
            for (int t = 0; t < vegetables.Length; t++)
            {
                Console.WriteLine(string.Format("vegetable " + t.ToString() + "  ->  {0}  "
                    , vegetables[t]));
            } 

            vegetables = fruits;
            Console.WriteLine("-------Referanses Equals -------------");
            //Console.WriteLine(string.Format("fruit 0  ->  {0}  ", fruits[0]));
            for (int r = 0; r < fruits.Length; r++)
            {
                Console.WriteLine(string.Format("fruits " + r.ToString() + "  ->  {0}  "
                    , fruits[r]));
            }
            for (int t = 0; t < vegetables.Length; t++)
            {
                Console.WriteLine(string.Format("vegetable " + t.ToString() + "  ->  {0}  "
                    , vegetables[t]));
            }

            //Console.WriteLine(string.Format("vegetable 0  ->  {0}  ", vegetables[0]));
            //Console.WriteLine(vegetables[1]);
            //Console.WriteLine(vegetables[2]);
            //Console.WriteLine(sebzeler[3]);


            Console.ReadLine();
        }



    } 



}
