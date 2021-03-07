waveHeight = 4  # 1
wL = 4  # 2
wH = waveHeight - 1  # 3
ctrl = wH  # 4

for x in range(0, wH + 1):
    cp = ord('A')  # 5
    for y in range(0, (wH * wL * 2) + 1):
        if (y % (wH * 2) == ctrl or
                y % (wH * 2) == wH + x):
            print(chr(cp), end="")
        else:
            print(" ", end="")  # single space
        cp += 1  # 6
        if (cp > ord('Z')):
            cp = cp - 26  # 7
    ctrl -= 1
    print()

    """
1) change value to increase/decrease the height of the wave
2) change value to increase/decrease the length of the wave
3) for loop cond
4) cond for printing
5) set printing character
6) increment print char
7) reset print char to 'A'
    """