using System;
namespace Project_Euler
{
	public class P014_Longest_Collatz_Sequence
	{
        /*
		 * The following iterative sequence is defined for the set of positive integers:
		 * n → n/2 (n is even)
		 * n → 3n + 1 (n is odd)
		 * 
		 * Using the rule above and starting with 13, we generate the following sequence:
		 * 
		 * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
		 * It can be seen that this sequence (starting at 13 and 
		 * finishing at 1) contains 10 terms. 
		 * Although it has not been proved yet (Collatz Problem), 
		 * it is thought that all starting numbers finish at 1.
		 * Which starting number, under one million, produces the longest chain?
		 * 
		 * NOTE: Once the chain starts the terms are allowed to go above one million.
		 */

		/*
		 * 1. This task will involve a lot of data-reuse, so we can make a list
		 * to keep track of where each collatz sequence ends.
		 *		eg. if a sequence goes to 8 and we know the sequence from 8
		 *		onwards, we can just add the length of collatz8 to the
		 *		current length
		 *	
		 *	2. loop from 1 to 999,999,999 and find collatz pattern length
		 *	
		 *	3. Once done, find largest number in list.
		 */

        public void run()
		{
			int range = 999_999;

			//We're using a dictionary to store the KV pairs for the number and
			//collatz length because it is conceptually the same
			//as a hashtable and as such is much faster than an array
			Dictionary<long, long> CollatzLengths = new Dictionary<long, long>();
			for (int i = 1; i <= range; i++)
			{
				Console.WriteLine($"Running Collatz {i}..");
				Collatz(i, CollatzLengths);
				Console.WriteLine($"{i} has length {CollatzLengths[i]}");
			}

			// find the largest value by key.
			long maxValue = 0;
			int maxKey = 0;
			foreach (int key in CollatzLengths.Keys)
			{
				if (CollatzLengths[key] >= maxValue)
				{
					maxKey = key;
					maxValue = CollatzLengths[key];
				}
			}
			Console.WriteLine($"The starting number {maxKey} produces the longest chain at length {maxValue}");
			
		}

		static void Collatz(int number, Dictionary<long, long> CollatzLengths)
		{
			int initialNumber = number;
			long workingNumber = number;
			int steps = 0;
			while (workingNumber != 1)
			{
				//increase efficiency by using the results from previous
				//collatz calculations
				if (CollatzLengths.ContainsKey(workingNumber))
				{
					CollatzLengths.Add(initialNumber, steps + CollatzLengths[workingNumber]);
					return;
				}
				//if even, divide by 2
				if (workingNumber % 2 == 0)
				{
					workingNumber /= 2;
				}
				//if odd, *=3 and +1
				else workingNumber = (workingNumber * 3) + 1;

				steps += 1;
			}
			//if we reach 1 without touching another previous answer, add the
			//answer to the dictionary
            CollatzLengths.Add(initialNumber, steps);
            return;
		}
	}
}

