for x in range(1, 6):
    t = x - 1
    for y in range(1, x+1):
        print(t + x, end=" ")
        t += 2
    print()