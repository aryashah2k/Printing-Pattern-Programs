wH = 4  # 1
wL = 4  # 2
num = wH + 1
jump = (num * 3 + 2) - (num + 3)
inc = 1
m = 0

for x in range(1, wH + 1):
    for y in range(1, wL + 1):
        if (x != wH):
            print("   ", end="")  # 3
        else:
            print("{:02d} ".format(num - 1), end="")
        for z in range(1, 5):
            if (x == 1 or z == 1 or z == 4):
                print("{:02d} ".format(num), end="")
                num += inc
            else:
                print("   ", end="")  # 3
        num -= inc  # 4
        if (x != wH):
            print("   ", end="")  # 3
        else:
            print("{:02d} ".format(num + 1), end="")
        num += jump
    jump -= 2
    inc = 5 + m
    m += 2
    num = wH - x + 1
    print()

    """
1) wH - change value to increase/decrease the height of the wave
2) wL - change value to increase/decrease the length of the wave
3) 3 whitespaces
4) restore value of num 

    """