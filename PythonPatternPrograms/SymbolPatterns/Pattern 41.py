n = 5  # size
for x in range(1, n + 1):
    for y in range(1, n + 1):
        if (y == 1 or x == y or x == n):
            print("*", end=" ")
        else:
            print(" ", end=" ")
    print()