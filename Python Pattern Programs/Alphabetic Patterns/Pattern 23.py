decr = 7
for x in range(4, 0, -1):
    for y in range(x, 5):
        print(" ", end="")
    for z in range(1, decr + 1):
        print(chr(z + 64), end="")
    decr -= 2
    print()