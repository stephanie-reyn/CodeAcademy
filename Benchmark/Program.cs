using FHS.CT.AlgoDat.Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace AlgoDat
{
    public class AlgoDatSortBenchmark<T> where T : IComparable<T>
    {
        // Parameters for the benchmark, specifying different array sizes.
        [Params(400, 800)]
        public int LargeArraySize;

        [Params(8, 16)]
        public int SmallArraySize;

        // Arrays to be used in the benchmark
        private T[] largeArray;
        private T[] smallArray;

        // Sorter instance for the AlgoDatSort<T> algorithm
        private AlgoDatSort<T>? sorter;

        // Setup method that initializes the sorter and generates random arrays.
        [GlobalSetup]
        public void GlobalSetup()
        {
            sorter = new AlgoDatSort<T>(8);

            largeArray = GenerateRandomArray(LargeArraySize);
            smallArray = GenerateRandomArray(SmallArraySize);
        }

        [Benchmark]
        public void SortBenchmark()
        {
            sorter.Sort(largeArray);
        }

        public static T[] GenerateRandomArray(int size)
        {
            T[] array = new T[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                T num = (T)Convert.ChangeType(r.Next(0, 1000), typeof(T));
                array[i] = num;
            }
            return array;
        }
    }

    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<AlgoDatSortBenchmark<int>>();

        }
    }
}