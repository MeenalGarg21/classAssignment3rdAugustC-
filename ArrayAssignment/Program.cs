using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace ArrayAssignment
    {


        class Program
        {
            static void Main(string[] args)
            {
                string[] Wild = { "Zebra", "ant", "owl", "lion" };
                string[] Animals = { "Zebra", "Kiwi", "Amazon", "Tiger" };
                string[] NewCities = { "Africa", "Newzealand", "JAminica", "India" };




                for (int i = 0; i < Wild.Length; i++)
                {
                    Console.WriteLine(Wild[i]);
                }
                foreach (string i in Wild)
                {
                    Console.WriteLine(i);
                }
                int p = 0;

                do
                {
                    Console.WriteLine("The array is" + Wild[p]);
                    p++;
                }
                while (p < Wild.Length);
                {
                    Console.WriteLine("Not possible");
                }
                p = 0;
                while (p < Wild.Length)
                {
                    Console.WriteLine(Wild[p]);
                    p++;
                }
                Array.Sort(Wild);
                for (int i = 0; i < Wild.Length; i++)
                {
                    Console.WriteLine(Wild[i]);
                }
                Array.Sort(Animals);
                Array.Sort(NewCities);
                //Sorted Array
                foreach (string i in Animals)
                {
                    Console.WriteLine(i);
                }
                //Sorted Array
                foreach (string i in NewCities)
                {
                    Console.WriteLine(i);

                }
            }
        }

    }




   