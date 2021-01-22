n = 5  # size
n1 = 0
n2 = 1
r = n1 + n2

for x in range(0, n):
    for y in range(0, x + 1):
        print(str(r) + " ", end="")
        r = n1 + n2
        n1 = n2
        n2 = r
    print()