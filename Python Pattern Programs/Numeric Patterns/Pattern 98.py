for x in range(5, 0, -1):
    for y in range(1, x+1):
        if x%2 != 0:
            print(y, end=" ")
        else: 
            print((x+1-y), end=" ")
    print()