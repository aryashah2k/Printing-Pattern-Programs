size = 3
for x in range(size, -(size + 1), -1):
    for y in range(abs(x), size + 1):
        print(y, end=" ")
    print()