size = 3
for x in range(size, -(size + 1), -1):
    for y in range(size, abs(x) - 1, -1):
        print(chr(y + 65), end=" ")
    print()