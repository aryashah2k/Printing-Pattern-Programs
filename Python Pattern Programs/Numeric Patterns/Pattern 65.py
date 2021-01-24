n = 5  # size
for x in range(1, n + 1):
    for s in range(n - 1, x - 1, -1):
        print(" ", end="")
    for y in range(1, x + 1):
        if (x % 2 == 0):
            print(chr(y + 64), end="")  # for char
        else:
            print(y, end="")
    print()