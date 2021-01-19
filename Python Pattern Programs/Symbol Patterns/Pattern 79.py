n=6
for x in range(1, n+1):
    for y in range(1, n+1):
        if x % 2 == 0: # for even rows
            if y % 2 != 0:
                print("x",end=" ")
            else:
                print("o",end=" ")
        else: # for odd rows
            if y % 2 != 0:
                print("o",end=" ")
            else:
                print("x",end=" ")
    print()