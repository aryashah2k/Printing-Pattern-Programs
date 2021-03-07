inc = 1
for x in range(5, 0, -1):
    for y in range(x, 0, -1):
        print(" ", end="")
    for z in range(1, inc + 1):
        print(z, end="")
    inc += 2;
    print()