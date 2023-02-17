﻿using System;

namespace Project_Euler
{
    class Problem2_Fibonacci
    {
        /*
         * Each new term in the Fibonacci sequence is generated by adding the
         * previous two terms. By starting with 1 and 2, the first 10 terms will be:
         *      1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
         *      
         * By considering the terms in the Fibonacci sequence whose values
         * do not exceed four million, find the sum of the even-valued terms.
         */

        /*
         * To solve this:
         *  1. Generate the fibonacci sequence up to 4,000,000
         *  2. If a given term %2 ==0, add it to a running total.
         */

        public void run()
        {
            int total = 0;

            int x = 0;
            int y = 1;

            while (x < 4000000 & y < 4000000)
            {
                //z = the next number in the sequence
                int z = x + y;
                //if z is even, add to total
                if (z % 2 == 0)
                {
                    total += z;
                }
                //offset x and y such that we can continue
                x = y;
                y = z;
            }
            Console.WriteLine($"Solution: {total}");
            Console.ReadKey();
        }
    }
}