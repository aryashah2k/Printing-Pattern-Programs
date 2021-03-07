for x in range(0, 4):
    for y in range(1, 5):
        if y <= x:
            print("0", end=" ")
        else:
            print(x + y, end=" ")
    print()