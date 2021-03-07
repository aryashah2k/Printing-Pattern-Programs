n = 9  # size
px = n // 2 + 1
p = 0  # print val
for x in range(1, n + 1):
    for y in range(1, n + 1):
        if (y == px or y == n - px + 1):
            print(chr(p + 65), end="")
        else:
            print(" ", end="")
    if (x <= n / 2):
        px -= 1
        p += 1
    else:
        px += 1
        p -= 1
    print()