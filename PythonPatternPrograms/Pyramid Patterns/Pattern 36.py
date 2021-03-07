n = 3  # size
k = 1
p = 1
for x in range(0, n):
    for s in range(n - 1, x, -1):
        print(" ", end="")
    for y in range(0, k):
        if (x == y):
            g = (p + 1) * (y + y)
            if (g == 0):
                g = 1
            print(" " + str(g), end="")
            continue
        p += 2
        print(" " + str(p), end="")
    k += 2
    print()