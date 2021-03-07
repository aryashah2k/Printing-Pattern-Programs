p_height = 5  # size
p_space = p_height - 1
m = 1
np = 1  # for num printing
cp = 'A'  # for char printing

for x in range(1, p_height + 1):
    for y in range(p_space, x - 1, -1):
        print(" ", end="")
    for z in range(1, m + 1):
        if (x % 2 != 0):
            print(np, end="")  # 1
            np += 1
        else:
            print(cp, end="")  # 2
            cp = chr(ord(cp) + 1)  # 3
        np = 1 if (np > 9) else np  # 4
        cp = 'A' if (cp > 'Z') else cp  # 5
    m += 2
    print()

    """
1) Print numbers if row is Odd
2) Print characters if row is Even
3) Incrementing the character
4) Reset number
5) Reset character
    """