n = 5
for x in range(0, n):
    for y in range(0, n):
        if y > x:
            print("*", end=" ")
        else:
            print(chr(y+65), end=" ")
    print()

    """
    65 > ASCII of 'A'
    """