n = 10  # size
n1 = 0
n2 = 1
r = 0

for x in range(0, n):
    for y in range(0, x + 1):
        n1 = n2
        n2 = r
        print(str(r) + " ", end="")
        r = n1 + n2
    n1 = 0
    n2 = 1
    r = 0
    print()