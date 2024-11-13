package p005smallestmultiple

import "fmt"

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
 */

func Run(run bool) {

	if !run {
		return
	}
	println("\nRunning P005")

	divisors := [12]int{7, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}

	currentNum := 20

	for {
		found := true
		for _, div := range divisors {
			if currentNum%div != 0 {
				found = false
				if !found {
					break
				}
			}
		}
		if found {
			fmt.Printf("Result: %v\n", currentNum)
			return
		} else {
			currentNum++
		}

	}

}
