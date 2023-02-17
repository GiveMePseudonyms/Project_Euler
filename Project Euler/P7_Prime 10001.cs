using System;
namespace Project_Euler
{
    /*
	 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
	 * we can see that the 6th prime is 13.
	 * What is the 10 001st prime number?
	 */

	/*
	 * My thoughts on solving this:
	 *	No prime is divisible by 2,
	 *	If the sum of a number's digits is a mulitple of 3, it can't be prime,
	 *	No prime greater than 5 ends in a 5,
	 *	Primes can't end in a 0 or be even (except 2)
	 *	
	 *	The fastest way to prove whether a number is prime:
	 *		- if it can be divided by 2, it's not prime
	 *		- If it can be divided by another prime then it can't be prime
	 *		
	 *	1. Div 2
	 *	2. Div by all known primes (including those discovered at runtime)
	 *	3. Store in array, 10001st array item is our solution.
	 * 
	 * Solution: 104743
	 */

    public class P7_Prime_10001
	{
		public void run()
		{
			//make a short list of primes to start with
			long[] primes = { 2, 3, 5, 7, 9, 11, 13 };
			//start at the next number which could be prime
			long number = 15;
			while (primes.Length <= 10001)
			{
				//if it's prime, add it to the list
				if (IsPrime(primes, number))
				{
					primes = primes.Append(number).ToArray();
					Console.WriteLine($"Prime {primes.Length-1}: {number}");
					number++;
					continue;
				}
				//otherwise continue
				else
				{
					number++;
					continue;
				}
			}
			//print the final prime in the list (10001st)
			Console.WriteLine(primes[primes.Length]);
		}

		static bool IsPrime(long[] primes, long number)
		{
			//a prime can't be perfectly divided by any smaller prime,
			//so we can use this to test for primes.
			foreach (long prime in primes)
			{
				if (number % prime == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}

