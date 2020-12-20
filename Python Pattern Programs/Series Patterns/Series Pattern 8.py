"""
In this program, we print the series of prime numbers up to 'n'.
* First we check each number (1 to n) for prime number.
* If the number is prime we print it.
"""

n = 10  # size
num = 1
count = 0

while (num <= n):
    for x in range(1, num + 1):
        if (num % x == 0):
            count += 1
    if (count == 2):  # true for prime
        print(" " + str(num), end="")
    count = 0
    num += 1

    """
 OUTPUT:

 2 3 5 7

    """