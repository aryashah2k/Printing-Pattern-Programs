n = 5  # size=5
px = 1
py = n * 2 - 1
for x in range(n, 0, -1):
    for y in range(1, n * 2 + 1):
        if (y == px or y == py):
            print(chr(x + 64), end="")
        else:
            print(" ", end="")
    px += 1
    py -= 1
    print()

    """
    5+64>> 69 >> ASCII of 'E'
    """