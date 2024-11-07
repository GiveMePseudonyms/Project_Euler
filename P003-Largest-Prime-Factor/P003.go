package p003largestprimefactor

import "fmt"

func Run() {
	println("\nRunning P003")

	workingNumber := 600851475143
	counter := 3

	for workingNumber > 1 {
		if workingNumber%counter == 0 {
			workingNumber /= counter
		} else {
			counter += 2
		}
	}

	fmt.Printf("%v", counter)
}
