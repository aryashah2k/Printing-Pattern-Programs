for x in range(1, 10):
    if (x == 1 or x == 9):
        s = 6
        t = 4
    elif (x == 2 or x == 8):
        s = 8
        t = 2
    elif (x == 3 or x == 7):
        s = 9
        t = 1
    else:
        s = 10
        t = 0

    for y in range(1, t + 1):
        print(" ", end="")
    for z in range(1, s + 1):
        print("* ", end="")

    print()for x in range(1, 6):
    for y in range(65, 70):
        print(chr(y), end="")
    print()