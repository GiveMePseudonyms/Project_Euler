using System;
namespace Project_Euler
{
	public class P9_Special_Pythagorean_Triplet
	{
        /*
		 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
		 * a^2 + b^2 = c^2
		 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
		 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
		 * Find the product abc.
		 */

		/*
		 * This solution could be brute-forced fairly easily but I would like
		 * to reduce redundancies in the code to increase performanece.
		 * 
		 * For example, it would be inefficient to square a set of numbers
		 * before we know they add to make 1000 since squaring is more
		 * expensive than adding.
		 */
        public void run()
		{
			for (int a = 1; a < 1000; a++)
			{
				int aSquared = a * a;

				for (int b = 1; b < 1000; b++)
				{
					int c = 1000 - a - b;
					int bSquared = b * b;
					int cSquared = c * c;

					if (aSquared + bSquared == cSquared)
					{
						Console.WriteLine($"Solution: a={a}, b={b}, c={c}");
						break;
					}
				}
			}
		}
	}
}

