using System;
using experiment_design.model;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        int[] n_5;
        int[] n_6;
        Random rnd;
        SortingAlgorithms sorter;

        [OneTimeSetUp]
        public void Init()
        {
            n_5 = new int[1000000];
            n_6 = new int[10000000];
            rnd = new Random(8);  //Seed carefully chosen by the team
            sorter = new SortingAlgorithms();
        }
        [SetUp]
        public void Reset()
        {
            for (int i = 0; i < n_6.Length; i++)
            {
                int nextRand = rnd.Next();

                n_6[i] = nextRand;
                if (i < n_5.Length)
                    n_5[i] = nextRand;
            }
        }
        /*
         * Those test dont contemplate all the treatments presented in the document. The reason behind this, is
         * that one of the the variable factors is the amount of RAM of the device. Which we can not control programatically.
         */
        [Test]
        public void Treatment_QuickSort_10_5()
        {
            sorter.QuickSort(n_5);
        }
        
        [Test]
        public void Treatment_QuickSort_10_6()
        {
            sorter.QuickSort(n_6);
        }
        
        [Test]
        public void Treatment_MergeSort_10_5()
        {
            sorter.MergeSort(n_5);
        }
        
        [Test]
        public void Treatment_MergeSort_10_6()
        {
            sorter.MergeSort(n_6);
        }
    }
}