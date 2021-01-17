n = 3
for x in range(1, n + 1):
    for s1 in range(n - 1, 0, -1):
        for s2 in range(n - 1, x - 1, -1):
            print(" ", end=" ")
        for y in range(0, x):
            print("*", end=" ")
        print()