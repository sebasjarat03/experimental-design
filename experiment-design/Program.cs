using System;
using experiment_design.model;

namespace experiment_design
{
    internal class Program
    {
        private static SortingAlgorithms sa;
        private static int[] n_5;
        private static int[] n_6;
        private static Random rnd;
        
        public static void Main(string[] args)
        {
            sa = new SortingAlgorithms();
            n_5 = new int[1000000];
            n_6 = new int[10000000];
            rnd = new Random(8);  //Seed carefully chosen by the team
            
            for (int i = 0; i < n_6.Length; i++)
            {
                int nextRand = rnd.Next();

                n_6[i] = nextRand;
                if (i < n_5.Length)
                    n_5[i] = nextRand;
            }
            
            Console.WriteLine("Merge sort 10^5: ");

            for (int i = 0; i < 100; i++)
            {
                DateTime start = DateTime.Now; 
                sa.MergeSort(n_5);
                DateTime end = DateTime.Now;
                Console.WriteLine(i + ") " + (end - start));
            }
            
            Console.WriteLine("Merge sort 10^6: ");

            for (int i = 0; i < 100; i++)
            {
                DateTime start = DateTime.Now; 
                sa.MergeSort(n_6);
                DateTime end = DateTime.Now;
                Console.WriteLine(i + ") " + (end - start));
            }
            
            Console.WriteLine("Quick sort 10^5: ");

            for (int i = 0; i < 100; i++)
            {
                int[] copy = new int[n_5.Length];

                for (int j = 0; j < copy.Length; j++)
                {
                    copy[j] = n_5[j];
                }
                
                DateTime start = DateTime.Now; 
                sa.QuickSort(copy);
                DateTime end = DateTime.Now;
                Console.WriteLine(i + ") " + (end - start));
            }
            
            Console.WriteLine("Quick sort 10^6: ");

            for (int i = 0; i < 100; i++)
            {
                int[] copy = new int[n_6.Length];

                for (int j = 0; j < copy.Length; j++)
                {
                    copy[j] = n_6[j];
                }
                
                DateTime start = DateTime.Now; 
                sa.QuickSort(copy);
                DateTime end = DateTime.Now;
                Console.WriteLine(i + ") " + (end - start));
            }
            
            

            
        }
    }
}