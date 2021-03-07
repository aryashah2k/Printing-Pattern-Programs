n = 5  # size
for x in range(0, n):
    for y in range(0, n):
        if (x == y or x + y == n - 1):
            print(chr(x + 65), end="")
        else:
            print(" ", end="")
    print()