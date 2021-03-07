n = 5
for x in range(0, n + 1):
    for y in range(0, x+1):
        if y != 0:
            print("*", end=" ")
        else:
            print(x, end=" ")
    print()