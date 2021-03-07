for x in range(1, 6):
    for y in range(5, x, -1):
        print(" ", end="")
    for z in range(0, x):
        print(str(x) + " ", end="")
    print()