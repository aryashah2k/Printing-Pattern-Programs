n = 4  # size
k = 0
for x in range(1, n + 1):
    k += x
    for y in range(k, k - x, -1):
        print(str(y) + " ", end="")
    print()