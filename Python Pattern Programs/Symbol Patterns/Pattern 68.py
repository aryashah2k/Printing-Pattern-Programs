n = 4
for x in range(n, -1, -1):
    for y in range(n, -1, -1):
        if y > x:
            print("*", end=" ")
        else:
            print(chr(x+65), end=" ")
    print()
    
    """
65 > ASCII of 'A'
    """