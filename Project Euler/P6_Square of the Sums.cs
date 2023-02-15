using System;
namespace Project_Euler
{
	public class P6_Square_of_the_Sums
	{
        /*
		 * The sum of the squares of the first ten natural numbers is,
		 *		1^2 + 2^2 +... 10^2 = 385
		 *	
		 * The square of the sum of the first ten natural numbers is,
		 *		(1+2+3+...10)^2 = 55^2 = 3025
		 * 
		 * Hence the difference between the sum of the squares of the 
		 * first ten natural numbers and the square of the sum is 
		 *		3025 - 385 = 2640
		 * 
		 * Find the difference between the sum of the squares of the 
		 * first one hundred natural numbers and the square of the sum.
		 */

        public void run()
		{
			long squareOfTheSum = 0;
			long sumOfTheSquare = 0;

			for (int i = 0; i <= 100; i++)
			{
				squareOfTheSum += i;
				sumOfTheSquare += i * i;
			}
			squareOfTheSum *= squareOfTheSum;
			long difference = squareOfTheSum - sumOfTheSquare;

			Console.WriteLine(difference);
		}
	}
}

