for x in range(1, 6):
    for y in range(5, x, -1):
        print(" ", end="")
    for z in range(1, x + 1):
        print(z, end="")
    print()