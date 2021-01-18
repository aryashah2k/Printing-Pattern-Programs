n = 8  # size even
c1 = (n - 1) // 2  # cond
c2 = 3 * n // 2 - 1  # cond

for x in range(0, n):
    for y in range(0, n):
        if (x + y <= c1 or x - y >= c1 or y - x >= c1 or x + y >= c2):
            print("* ", end="")  # *space
        else:
            print("  ", end="")  # two spaces
    print()