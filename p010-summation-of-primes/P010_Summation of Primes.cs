using System;
using System.Collections.Generic;
namespace Project_Euler
{
	public class P010_Summation_of_Primes
	{
        /*
		 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
		 * Find the sum of all the primes below two million.
		 */

        /* My thoughts on solving this:
		 * 
		 * We will need a prime number generator.
		 * 
		 * Brute-forcing primes through trial division is fine for smaller ranges
		 * but a range of 2,000,000 will take far too long so we will need to use
		 * a seive of eratosthenes.
		 * 
		 * This was EXCEPTIONALLY difficult to implement since I had never heard
		 * of a sieve of eratosthenes and had to do a lot of research on it.
		 */
        public void run()
		{
			int target = 2_000_000;

			//Generate a bool array equal to the size of our target + 1
			bool[] isPrime = new bool[target + 1];
			//make all indices in the array greater than 2 true;
			for (int i = 2; i <= target; i++)
			{
				isPrime[i] = true;
			}

			// a sieve of E. will multiply nonprimes to filter them out, so
			//we only actually need to go as high as root(target)
			int upperLimit = (int)Math.Sqrt(target);

			// if the number is prime, we remove it and all it's multiples upto
			// its own square from the sieve and then add it to i.
			for (int i = 2; i <= upperLimit; i++)
			{
				if (isPrime[i])
				{
					for (int j = i * i; j <= target; j += i)
					{
						isPrime[j] = false;
					}
				}
			}

			long sumOfPrimes = 0;
			//now we sum the index of each true bool
			for (int i = 0; i <= isPrime.Length-1; i++)
			{
				if (isPrime[i])
				{
					sumOfPrimes += i;
				}
			}

			Console.WriteLine($"The sum of the first {target} primes is {sumOfPrimes}");
		}
	}

}

