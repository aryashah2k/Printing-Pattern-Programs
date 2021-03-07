n = 5  # size
for x in range(1, n + 1):
    for y in range(1, n + 1):
        if (x <= y):
            print("o", end=" ")
        else:
            print("x", end=" ")
    print()