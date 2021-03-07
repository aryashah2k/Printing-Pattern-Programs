p_height=5
for x in range(1, p_height+1):
    for y in range(p_height-1, x-1, -1):
        print(" ", end="")
    for z in range(1, x + 1):
        if x%2==0:
            print("* ", end="")
        else:
            print("+ ", end="")
    print()