wH = 4  # 1
wL = 4  # 2
pc = wH - 1  # 3

for x in range(0, wH + 1):
    pchar = ord('a')  # 4
    for y in range(0, (wH * wL * 2)):
        if (y % (wH * 2) == pc or
                y % (wH * 2) == wH + x):
            print(chr(pchar), end="")
        else:
            print(" ", end="")  # single space
        pchar += 1  # 5
        if (pchar > ord('z')):  # 6
            pchar = pchar - 26  # 7
    pc -= 1
    print()

    """
1) change value to increase/decrease the height of the wave
2) change value to increase/decrease the length of the wave
3) cond for printing
4) set printing character
5) increment print char
6) reset print char to 'a'
    """