n = 5  # size=5
px = n
py = n
for x in range(1, n + 1):
    for y in range(1, n * 2 + 1):
        if (y == px or y == py):
            print(chr(x + 64), end="")  # 1
        else:
            print(" ", end="")
    px -= 1
    py += 1
    print()

    """
    1+64>> 65 >> ASCII of 'A'
    
    """