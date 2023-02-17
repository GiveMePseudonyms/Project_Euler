using System;
using System.Linq;

namespace Project_Euler
{
    /* 
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

	/*
	 * Solution:
	 * My original instinct here was to generate prime numbers and test them
	 * against the working number recursively to find the final iteration.
	 * This is inefficient and contians room for error since I have no idea
	 * how many primes I will have to test.
	 * 
	 * After some more thought and some paper-tests:
	 * 
	 *	We don't actually need to follow the implied wording of the question to
	 *	solve this.
	 *	
	 *	We can just loop over numbers to see if they divide sans modulus until
	 *	we get a result of 1 when dividing the looped number by the
	 *	working number.
	 *	
	 *	If we get a 1 from the working number, we know the counter number is
	 *	the largest possible prime factor.
	 */

    public class P3_LargestPrimeFactor
	{
		public void run()
		{
			//working number = the value of our work to reduce to a prime
			long workingNumber = 600851475143;
			//start at 3 since 2 would result in a nonprime
			int counter = 3;
			//temp value to store workingnum
            long x = workingNumber;

            while (workingNumber > 1)				
			{
				// if we can perfectly divide working number by our denominator
				// then we know it's a factor leading to a prime
				if (workingNumber % counter == 0)
				{
					workingNumber /= counter;
					x = workingNumber;
				}
				//otherwise, increment the denominator by 2 to skip the even numbers
				else
				{
					x = workingNumber;
					counter += 2;
				}
			}
			Console.WriteLine(counter);
        }
	}
}

