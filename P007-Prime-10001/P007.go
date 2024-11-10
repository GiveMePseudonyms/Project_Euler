package p007prime10001

import "fmt"

/*
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
 * we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 */

/*
 * My thoughts on solving this:
 *	No prime is divisible by 2,
 *	If the sum of a number's digits is a mulitple of 3, it can't be prime,
 *	No prime greater than 5 ends in a 5,
 *	Primes can't end in a 0 or be even (except 2)
 *
 *	The fastest way to prove whether a number is prime:
 *		- if it can be divided by 2, it's not prime
 *		- If it can be divided by another prime then it can't be prime
 *
 *	1. Div 2
 *	2. Div by all known primes (including those discovered at runtime)
 *	3. Store in array, 10001st array item is our solution.
 *
 * Solution: 104743
 */

func Run() {
	println("\nRunning P007")

	var knownPrimes [10001]int

	knownPrimes[0] = 2
	knownPrimes[1] = 3
	knownPrimes[2] = 5
	knownPrimes[3] = 7
	knownPrimes[4] = 11
	knownPrimes[5] = 13

	num := 17

	for i := 6; i < 10001; {
		if IsPrime(num, &knownPrimes) {
			knownPrimes[i] = num
			num++
			i++
			continue
		}
		num++
	}

	fmt.Printf("Result = %v", knownPrimes[10000])
}

func IsPrime(num int, knownPrimes *[10001]int) bool {
	return (num%2 != 0) && !DivisibleByExistingPrime(num, knownPrimes)
}

func DivisibleByExistingPrime(num int, knownPrimes *[10001]int) bool {
	for _, knownPrime := range *knownPrimes {
		if knownPrime == 0 {
			continue
		}
		if num%knownPrime == 0 {
			return true
		}
	}
	return false
}
