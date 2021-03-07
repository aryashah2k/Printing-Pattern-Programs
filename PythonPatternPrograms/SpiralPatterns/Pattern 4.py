i = 1
rows = 10
k = 1

for x in range(1, rows * 2 + 1, +2):
    if k % 2 == 1:
        print("{:02d} ".format(i), end="")
        print("{:02d} ".format(i + 1), end="")
        print("{:02d} ".format(i + 2), end="")
        print("{:02d} ".format(i + 3), end="")
        k += 1
        i += 4
    else:
        print("{:02d} ".format(i + 3), end="")
        print("{:02d} ".format(i + 2), end="")
        print("{:02d} ".format(i + 1), end="")
        print("{:02d} ".format(i), end="")
        k += 1
        i += 4
    print()