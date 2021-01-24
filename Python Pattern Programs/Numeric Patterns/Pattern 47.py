num = 1
for x in range(1, 5):
    for y in range(1, x + 1):
        print(str(num) + " ", end="")
        num += 1
    print()