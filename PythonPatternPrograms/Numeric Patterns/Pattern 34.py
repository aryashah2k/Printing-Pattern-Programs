size = 4
for x in range(size, -(size + 1), -1):
    for y in range(1, abs(x) + 1):
        print(" ", end="")
    p = 1
    for z in range(size, abs(x) - 1, -1):
        print(str(p) + " ", end="")
        p += 1
    print()