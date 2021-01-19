# Another Logic

for x in range(1, 6):
    for y in range(5, 0, -1):
        if x >= y:
            print("* ", end="")
        else:
            print(" ", end="")
    print()