package p010summationofprimes

import (
	"fmt"
)

/*
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */

/* My thoughts on solving this:
 *
 * We will need a prime number generator.
 *
 * Brute-forcing primes through trial division is fine for smaller ranges
 * but a range of 2,000,000 will take far too long so we will need to use
 * a seive of eratosthenes.
 */

func Run(run bool) {

	if !run {
		return
	}

	println("\nRunning p010")

	var n int = 2000000 - 1

	list := make([]bool, n+1)
	for i := range list {
		list[i] = true
	}
	list[0], list[1] = false, false

	begin := 1
	for {
		if begin*begin > n {
			break
		}
	Loop:
		for i, v := range list {
			if v && i > begin {
				// sieve multiples of i
				for j := i + i; j <= n; j += i {
					list[j] = false
				}
				begin = i
				break Loop
			}
		}
	}

	var c int64 = 0
	for i, v := range list {
		if v {
			c += int64(i)
		}
	}
	fmt.Printf("Result: %v\n", c)
}
