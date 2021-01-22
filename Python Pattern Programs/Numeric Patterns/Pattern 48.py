n = 5  # size
for x in range(1, n + 1):
    k = x
    for y in range(1, x + 1):
        print(str(k) + " ", end="")
        k = k + (n - y)
    print()

    """
Interesting fact about this pattern:

The last last value (botton-right corner) of the pattern is equal to the sum of all numbers from 1 to n.

e.g
Suppose, n=5

1 
2 6 
3 7 10 
4 8 11 13 
5 9 12 14 15 

last value is 15, that is equal to 1+2+3+4+5

    """