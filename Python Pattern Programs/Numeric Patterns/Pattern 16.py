inc = 1
num = 1
for x in range(5, 0, -1):
    for y in range(x, 0, -1):
        print(" ", end="")
    print(str(num) * inc)
    num += 2
    inc += 2;