inc = 1
char = 65  # ASCII of 'A'
for x in range(5, 0, -1):
    for y in range(x, 0, -1):
        print(" ", end="")
    print(chr(char) * inc, end="")
    char += 2
    inc += 2;
    print()