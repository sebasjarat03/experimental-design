using System;
using experiment_design.model;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestProject
{
    [TestFixture]
    public class SortingTest
    {
        int[] arr;
        Random rnd;
        SortingAlgorithms sorter;
        
        [OneTimeSetUp]
        public void Init()
        {
            arr = new int[1000000];
            rnd = new Random();
            sorter = new SortingAlgorithms();
        }
        
        [SetUp]
        public void Reset()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int nextRand = rnd.Next();
                arr[i] = nextRand;
            }
        }

        [Test]
        public void QuickSortTest()
        {
            sorter.QuickSort(arr);

            for (int i = 0; i < arr.Length-1; i++)
            {
                Assert.True(arr[i] <= arr[i+1]);
            }
        }
        
        [Test]
        public void MergeSortTest()
        {
            int[] newArr = sorter.MergeSort(arr);

            for (int i = 0; i < newArr.Length-1; i++)
            {
                Assert.True(newArr[i] <= newArr[i+1]);
            }
        }
    }
}