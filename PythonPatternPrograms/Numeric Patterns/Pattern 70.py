n = 5  # size
for x in range(1, n + 1):
    for s in range(n - 1, x - 1, -1):
        print(" ", end="")
    for y in range(1, x + 1):
        if (x % 2 != 0):
            print(chr(x + 64) + " ", end="")  # for char
        else:
            print(str(x) + " ", end="")
    print()for x in range(1, 6):
    for y in range(65, 70):
        print(chr(y), end="")
    print()