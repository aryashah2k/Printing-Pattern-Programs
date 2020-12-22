wH = 5  # 1
wL = 4  # 2
insp = 1  # 3
ousp = 2  # 4
inc = 1
jump = (wH * 3) - (wH + 1)
num = wH

for x in range(1, wH + 1):
    for y in range(1, wL + 1):
        for z in range(1, ousp + 1):
            print(" ", end="")
        print("{:02d}".format(num), end="")
        for z in range(1, insp + 1):
            print(" ", end="")
        num += inc
        print("{:02d}".format(num), end="")
        for z in range(1, ousp + 1):
            print(" ", end="")
        print(" ", end="")
        num += jump

    ousp = (x + 1 != wH)  # 5

    if (x + 1 != wH):  # 6
        insp = 3
    else:
        insp = 5

    num = wH - x
    inc += 2
    jump -= 2
    print()

    """
1) wH - change value to increase/decrease the height of the wave
2) wL - change value to increase/decrease the length of the wave
3) inner space
4) outer space
5) set value of ousp to 1 if x+1 is not equal to wave height (wH) or 0 otherwise
6) set value of insp to 3 if x+1 is not equal to wave height (wH) or 5 otherwise
    """