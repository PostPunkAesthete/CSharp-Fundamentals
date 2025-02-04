﻿using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    arr1[i] = nums[0];
                    arr2[i] = nums[1];
                }
                else
                {
                    arr1[i] = nums[1];
                    arr2[i] = nums[0];
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
