size = 3
for x in range(size, -(size + 1), -1):
    for y in range(abs(x), 0, -1):
        print(" ", end=" ")
    for z in range(size, abs(x) - 1, -1):
        print(chr(z + 65), end=" ")
    print()