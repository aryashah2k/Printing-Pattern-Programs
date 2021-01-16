size = 5
for x in range(size, -(size), -1):
    for y in range(1, abs(x) + 1):
        print(" ", end="")
    for z in range(size, abs(x), -1):
        print("* ", end="")
    print()