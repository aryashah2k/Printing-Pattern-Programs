n = 3
inc = 1
for x in range(0, n):
    for s1 in range(n - 1, 0, -1):
        for s2 in range(n - 1, x, -1):
            print(" ", end=" ")
        for y in range(0, inc):
            print("*", end=" ")
        print()
    inc += 2