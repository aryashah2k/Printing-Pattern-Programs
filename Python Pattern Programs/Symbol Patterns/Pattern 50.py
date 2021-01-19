height = 3  # tree height
width = 4  # tree width
space = height * width  # space from corner
m = 1  # to print

# tree's upper part - leaves
for r in range(1, height + 1):
    for x in range(m, width + 1):
        for y in range(space, x + 1, -1):
            print(" ", end="")
        for z in range(1, x + 1):
            print("* ", end="")
        print()
    m += 2
    width += 2

# tree's lower part - stem
for x in range(1, 5):
    for y in range(space - 5, 0, -1):
        print(" ", end="")
    for z in range(1, 5):
        print("* ", end="")
    print()