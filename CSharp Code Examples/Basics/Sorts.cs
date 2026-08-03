using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Basics
{
    internal class Sorts
    {
        //Authors: Jake Peringatt
        //A class demonstrating sorts, bubble sort and merge sort, and comparing the time taken
        public static void run()
        {

            int[] num1 = new int[20000]; //creating a huge array to show how long it takes for large datasets
            Random random = new Random();

            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = random.Next(1, 50000); //randomising each array
            }

            int[] num2 = (int[])num1.Clone();

            Console.WriteLine("Sorting algorithms:");

            Console.WriteLine("Bubble Sort");
            Console.WriteLine("Tap any key to Sort...");
            Console.ReadKey();
            Console.WriteLine();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(num1);
            stopwatch.Stop();

            Console.WriteLine("Sorted Array");

            Console.WriteLine("Time elapsed to sort(ticks): " + stopwatch.ElapsedTicks);
            Console.WriteLine("Time elapsed to sort(ms): " + stopwatch.ElapsedMilliseconds);


            Console.WriteLine();
            Console.WriteLine("Merge Sort");
            Console.WriteLine("Tap any key to Sort...");
            Console.ReadKey();
            Console.WriteLine();



            stopwatch.Restart();
            MergeSort(num2, 0, num2.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Sorted Array");

            Console.WriteLine("Time elapsed to sort(ticks): " + stopwatch.ElapsedTicks);
            Console.WriteLine("Time elapsed to sort(ms): " + stopwatch.ElapsedMilliseconds);



        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - 1) - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j+1] = temp;
                    }
                }
            }
            
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        public static void Merge(int[] array, int left, int middle, int right)
        {
            int lSize = middle - left + 1;
            int rSize = right - middle;

            int[] lArr = new int[lSize];
            int[] rArr = new int[rSize];

            for (int i = 0; i < lSize; i++)
            {
                lArr[i] = array[left + i];
            }
            for (int i = 0; i < rSize; i++)
            {
                rArr[i] = array[middle + i + 1];
            }

            int a = 0;
            int b = 0;

            int k = left;
            while (a < lSize && b < rSize)
            {
                if (lArr[a] <= rArr[b])
                {
                    array[k] = lArr[a];
                    a++;
                }
                else
                {
                    array[k] = rArr[b];
                    b++;
                }

                k++;
            }

            while (a < lSize)
            {
                array[k] = lArr[a];
                a++;
                k++;

            }
            while (b < rSize)
            {
                array[k] = rArr[b];
                b++;
                k++;
            }

        }
    }

}