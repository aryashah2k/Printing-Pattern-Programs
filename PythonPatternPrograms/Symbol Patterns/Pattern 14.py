n = 5  # size=5
px = 1
py = n * 2 - 1
for x in range(1, n + 1):
    for y in range(1, n * 2 + 1):
        if (y == px or y == py):
            print("*", end="")
        else:
            print(" ", end="")
    px += 1
    py -= 1
    print()