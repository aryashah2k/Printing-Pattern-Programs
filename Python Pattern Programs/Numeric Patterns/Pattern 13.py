for x in range(5, 0, -1):
    for y in range(x, 5):
        print(" ", end="")
    for z in range(0, x):
        print(x, end="")
    print()