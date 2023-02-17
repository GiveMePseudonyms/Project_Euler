using System;
namespace Project_Euler
{
	public class P4_Palindromic_Numbers
	{
        /*
		 * A palindromic number reads the same both ways. 
		 * The largest palindrome made from the product of two 2-digit 
		 * numbers is 9009 = 91 × 99.
		 * 
		 * Find the largest palindrome made from the product of two 3-digit numbers.
		 */

		/*
		 * To solve:
		 * 
		 * run a loop of x = 100 through 999 and y = 100 through 999
		 * mutliply x and y, if the length of the product >= the length of
		 * the largest known palindromic, check if the product is palindromic
		 *		Even length palindromes can be split in half and the 1st half 
		 *		reversed to get the second half
		 *		
		 *		Odd length palindromes can be split in half -1, then reversed.
		 *		
		 */
        public void run()
		{
			int longestPalindrome = 0;
			int product;
			//x and y are used to loop through the range
			int x;
			int y;

			for (x = 100; x <= 999; x++)
			{
				for (y = 100; y <= 999; y++)
				{
					product = x * y;
					//if the result is longer than the most recent palindrome
					//we can check it
					if (product.ToString().Length >= longestPalindrome.ToString().Length)
					{
						if (IsPalindromic(product) & product > longestPalindrome)
						{
							longestPalindrome = product;
							Console.WriteLine($"Match found: {x}*{y} = {longestPalindrome}");
						}
					}
					
				}
			}
			Console.WriteLine($"Longest match = {longestPalindrome}");
		}

		private static bool IsPalindromic(int product)
		{
			//convert to string
			string numString = product.ToString();

			//find the midpoint
			int halfLength = (int)Math.Ceiling(numString.Length / 2d);

			//split the string at the midpoint
            string firstHalf = numString.Substring(0, halfLength);


			//get the individual chars and reverse them
            char[] chars = firstHalf.ToCharArray();
			Array.Reverse(chars);
			string correctSecondHalf = new string(chars);

			//check if this matches the second half
            string actualSecondhalf = numString.Substring(halfLength);

            if (correctSecondHalf == actualSecondhalf)
			{
				return true;
			}
			else return false;
		}
	}
}

