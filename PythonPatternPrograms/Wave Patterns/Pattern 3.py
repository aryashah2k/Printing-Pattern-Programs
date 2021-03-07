waveHeight = 4  # 1
wL = 4  # 2
wH = waveHeight - 1  # 3
pc = wH  # 4

for x in range(0, wH + 1):
    for y in range(0, (wH * wL * 2) + 1):
        if (y % (wH * 2) == pc or
                y % (wH * 2) == wH + x):
            print("{:02d}".format(y), end="")
        else:
            print("  ", end="")  # 2 spaces
    pc -= 1
    print()

    """
1) change value to increase/decrease the height of the wave
2) change value to increase/decrease the length of the wave
3) for loop cond
4) cond for printing
    """