﻿using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int temp = nums[0];

                for (int j = 0; j < nums.Length-1; j++)
                {
                    nums[j] = nums[j + 1];
                }

                nums[nums.Length - 1] = temp;
            }

            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
