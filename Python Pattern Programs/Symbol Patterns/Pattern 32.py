for x in range(6, 0, -1):
    if (x % 2 != 0):
        ctrl = x + 1
    else:
        ctrl = x
    for y in range(0, ctrl):
        print("*", end="")
    print()