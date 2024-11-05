package p002fibonacci

import "fmt"

/*
 * Each new term in the Fibonacci sequence is generated by adding the
 * previous two terms. By starting with 1 and 2, the first 10 terms will be:
 *      1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 *
 * By considering the terms in the Fibonacci sequence whose values
 * do not exceed four million, find the sum of the even-valued terms.
 */

/*
 * To solve this:
 *  1. Generate the fibonacci sequence up to 4,000,000
 *  2. If a given term %2 ==0, add it to a running total.
 */

func Run() {
	println("\nRunning P002")

	curr := 1
	last := 1
	next := 1
	sum := 0

	for {
		if curr <= 4000000 {
			if curr%2 == 0 {
				sum += curr
			}
			next = curr + last
			last = curr
			curr = next
		} else {
			break
		}
	}

	fmt.Printf("sum = %v", sum)

}
