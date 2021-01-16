n = 5  # size=5
px = n
py = n
for x in range(1, n + 1):
    for y in range(1, n * 2):
        if (y > px and y < py):
            print(" ", end="")
        else:
            print("*", end="")
    px -= 1
    py += 1
    print()