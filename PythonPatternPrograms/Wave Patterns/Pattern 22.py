wH = 4  # 1
wL = 4  # 2

for x in range(1, wH + 1):
    for y in range(1, wL + 1):
        if (x != wH):
            print("  ", end="")  # 3
        else:
            print("* ", end="")  # 4
        for z in range(1, 5):
            if (x == 1 or z == 1 or z == 4):
                print("* ", end="")  # 4
            else:
                print("  ", end="")  # 3

        if (x != wH):
            print("  ", end="")  # 3
        else:
            print("* ", end="")  # 4
    print()

    """
1) wH - change value to increase/decrease the height of the wave
2) wL - change value to increase/decrease the length of the wave
3) 2 whitespaces
4) whitespace after * 

    """