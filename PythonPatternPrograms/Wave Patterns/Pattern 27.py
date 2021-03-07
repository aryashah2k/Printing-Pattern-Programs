wH = 5  # 1
wL = 4  # 2

for x in range(1, wH + 1):
    for y in range(1, wL + 1):
        for z in range(1, wH + 1):
            if (x == z or x + z == wH + 1):
                print(">>", end="")
            else:
                print("  ", end="")  # 3
    print()

    """
1) wH - change value to increase/decrease the height of the wave
2) wL - change value to increase/decrease the length of the wave
3) 2 whitespaces
    """