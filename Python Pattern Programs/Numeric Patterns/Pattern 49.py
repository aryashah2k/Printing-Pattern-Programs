n = 5  # size
for x in range(1, n + 1):
    if (x % 2 == 0):
        k = 2
    else:
        k = 1
    for y in range(1, x + 1):
        print(str(k) + " ", end="")
        k += 2
    print()