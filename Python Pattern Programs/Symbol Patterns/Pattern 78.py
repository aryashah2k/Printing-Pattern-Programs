for row in range(0, 6):
    for col in range(0, 7):
        if (row == 0 and col % 3 != 0) or (row == 1 and col % 3 == 0) or (row - col == 2)or(row + col == 8):
            print("*",end=" ")
        else:
            print(" ",end=" ")
    print(" ")