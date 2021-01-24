decr = 7
for x in range(4, 0, -1):
    for y in range(x, 5):
        print(" ", end="")
    print(str(decr) * decr)
    decr -= 2