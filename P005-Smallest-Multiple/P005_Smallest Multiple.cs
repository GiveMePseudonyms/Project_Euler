using System;
namespace Project_Euler
{
    /*
	 * 2520 is the smallest number that can be divided by each of the numbers 
	 * from 1 to 10 without any remainder.
	 * What is the smallest positive number that is evenly divisible 
	 * by all of the numbers from 1 to 20?
	 */

    /*
	 * Brute force is an obvious solution to this question, but I suspect
	 * there is a smarter way.
	 * 
	 * We can immediately reduce the range to 2-20 since all numbers are
	 * divisible by 1.
	 * 
	 * We can factor out the smaller numbers since their division will be
	 * implied by others.
	 * 
	 * For example:
	 * We can remove 2 because any number divisible by 20 is inherently
	 * divisible by 2 since 2 is a factor of 20. The same goes for:
	 * 2->4->8->16
	 * 3->6->12
	 * 4->8->16
	 * 5->10->20
	 * 7->14
	 * 9->18
	 * Therefore, our factors should include:
	 * 7, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
	 * 
	 * This logic can also extend to 20 itself. Given that 10 is a factor of 20,
	 * 2520 must also be a factor of 20s answer. We can use this check to
	 * speed up the execution of the code.
	 * 
	 * Solution: 232,792,560
	 */

    public class P5_Smallest_Multiple
	{
		public void run()
		{
			//grab the relevant factors and put them in an array
			int[] factors = { 7, 9, 11, 12, 13, 14, 16, 16, 17, 18, 19, 20 };
			int number = 20;
			while (true)
			{
				bool match = true;
				// if the number is perfectly divisible by 2520 then we know
				//it's not a match since 2520 can be perfectly divided by 1-10
				//and 1-20 is exactly twice the working range
				if(number % 2520 != 0)
				{
					number++;
					continue;
				}
				foreach (int factor in factors)
				{
					//check divisibility for each factor
					Console.WriteLine($"Testing {number}");
					if (number % factor != 0)
					{
						match = false;
					}
				
				}
				if (match)
				{
					Console.WriteLine($"Match found: {number}");
					break;
				}
				else number++;
			}
		}
	}
}

