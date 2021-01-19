for x in range(0, 5):
    for y in range(4, x - 1, -1):
        print(chr(y + 65), end="")
    print()