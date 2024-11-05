package p001multiplesof3or5

import "fmt"

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5,
 * we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

/*
 * To solve this problem we will need to:
 *  1. Use modulo to find perfect divisions of a given number into 3
 *  2. If it ends in a 0 or 5 then add it to the total.
 *  3. If it divides perfectly into 3 and doesn't end in 0 or 5,
 *      add it to the running total.
 *  4. Show the total at the end.
 *
 * Things to consider:
 *  0 and 1000 shouldn't be included.
 */
func Run() {
	fmt.Println("Running P001")
}
