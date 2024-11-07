package p004palindromicnumbers

import (
	"fmt"
	"strconv"
)

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
 * run a loop of x = 999 through 100 and y = 999 through 100
 * mutliply x and y.

 The first palindromic will be the largest.
 *
 *		Odd length palindromes can be split in half -1, then reversed.
 *
*/

func Run() {
	println("\nRunningP004")

	largest := 0
	for x := 999; x >= 100; x-- {

		for y := 999; y >= 100; y-- {
			if IsPalindromic(x * y) {
				if x*y > largest {
					largest = x * y
				}
			}
		}
	}

	fmt.Printf("Result = %v", largest)
}

func IsPalindromic(num int) bool {
	str := strconv.Itoa(num)

	var sideA string
	var sideB string

	if len(str)%2 == 0 {
		sideA = str[len(str)/2:]
		sideB = str[:len(str)/2]
	} else {
		sideA = str[(len(str)/2)-1:]
		sideB = str[:(len(str)/2)-1]
	}
	if RevserseString(sideA) == sideB {
		return true
	}
	return false
}

func RevserseString(str string) string {
	runes := []rune(str)
	for i, j := 0, len(runes)-1; i < j; i, j = i+1, j-1 {
		runes[i], runes[j] = runes[j], runes[i]
	}
	return string(runes)
}
