using FHS.CT.AlgoDat.Algorithms;
using BenchmarkDotNet.Attributes;
using System;

namespace AlgoDat
{
    public class AlgoDatSort<T> where T : IComparable<T>
    {
        // Property to set the cutoff value for the sorting algorithm.
        public int Cutoff { get; set; }

        // Constructor to initialize the AlgoDatSort<T> with a cutoff value
        public AlgoDatSort(int cutoff)
        {
            Cutoff = cutoff;
        }

        // Benchmark method for the sorting algorithm
        [Benchmark]
        public void Sort(T[] list)
        {
            // If the array is smaller than the cutoff, use insertion sort
            if (list.Length < Cutoff)
            {
                InsertionSort<T>.Sort(list);
            }
            else
            {
                // Otherwise, use merge sort
                Sort(list, 0, list.Length - 1);
            }
        }

        // Recursive method to perform merge sort on the array
        private static void Sort(T[] list, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                // Recursively sort the left and right halves.
                Sort(list, left, middle);
                Sort(list, middle + 1, right);
                // Merge the sorted halves.
                Merge(list, left, middle, right);
            }
        }

        // Helper method to merge two sorted halves of the array
        private static void Merge(T[] list, int left, int middle, int right)
        {
            int lPointer = left;
            int rPointer = middle + 1;
            T[] temp = new T[right - left + 1];
            int cPointer = 0;

            while (lPointer <= middle && rPointer <= right)
            {
                // Compare elements and merge them in sorted order.
                if (list[lPointer].CompareTo(list[rPointer]) <= 0)
                {
                    temp[cPointer] = list[lPointer];
                    lPointer++;
                }
                else
                {
                    temp[cPointer] = list[rPointer];
                    rPointer++;
                }
                cPointer++;
            }

            // Copy remaining elements from the left and right halves.
            while (lPointer <= middle)
            {
                temp[cPointer] = list[lPointer];
                lPointer++;
                cPointer++;
            }

            while (rPointer <= right)
            {
                temp[cPointer] = list[rPointer];
                rPointer++;
                cPointer++;
            }

            // Copy merged elements back to the original array.
            for (int i = 0; i < temp.Length; i++)
            {
                list[left + i] = temp[i];
            }
        }
    }
}