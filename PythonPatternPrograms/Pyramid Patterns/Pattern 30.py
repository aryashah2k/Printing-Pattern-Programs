for x in range(5, 0, -1):
    for y in range(x, 5):
        print(" ", end="")
    for z in range(x, 0, -1):
        print(chr(z + 64) + " ", end="")
    print()