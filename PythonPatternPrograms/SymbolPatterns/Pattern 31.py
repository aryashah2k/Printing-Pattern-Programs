for x in range(1, 7):
    if (x % 2 != 0):
        ctrl = x + 1
    else:
        ctrl = x
    for y in range(6, ctrl, -1):
        print(" ", end="")
    for z in range(0, ctrl):
        print("*", end="")
    print()