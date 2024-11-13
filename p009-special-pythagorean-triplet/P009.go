package p009specialpythagoreantriplet

import "fmt"

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

func Run(run bool) {

	if !run {
		return
	}
	println("\nRunning P009")

	for a := 1; a <= 1000; a++ {
		for b := a; b < 500-a/2; b++ {
			c := 1000 - a - b
			if a*a+b*b == c*c {
				fmt.Printf("Solution: a = %v, b = %v, c = %v\nResult = %v\n", a, b, c, a*b*c)
				return
			}
		}
	}
}
