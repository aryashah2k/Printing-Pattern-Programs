wH = 4  # 1
wL = 4  # 2
pc = wH - 1  # 3

for x in range(0, wH + 1):
    for y in range(0, (wH * wL * 2)):
        if (y % (wH * 2) == pc):
            print("/", end="")
        elif (y % (wH * 2) == wH + x):
            print("\\", end="")
        else:
            print(" ", end="")  # single space
    pc -= 1
    print()

    """
1) change value to increase/decrease the height of the wave
2) change value to increase/decrease the length of the wave
3) cond for printing
    """