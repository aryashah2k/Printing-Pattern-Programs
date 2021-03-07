size = 4
p = 1
for x in range(size, -(size + 1), -1):
    for y in range(1, abs(x) + 1):
        print(" ", end="")

    if (x >= 0):
        p = 1
    else:
        p = y + 1

    for z in range(size, abs(x) - 1, -1):
        print(str(p) + " ", end="")
        p += 1
    print()