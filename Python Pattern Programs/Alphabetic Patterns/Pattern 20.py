inc = 1
for x in range(0, 5):
    for y in range(4, x, -1):
        print(" ", end="")
    for z in range(x, -(x + 1), -1):
        print(chr(x - abs(z) + 65), end="")
    print()