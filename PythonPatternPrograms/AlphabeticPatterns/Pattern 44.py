n = 4  # size
p = 1  # for printing
q = (n * n) + 1

for x in range(n, 0, -1):
    for y in range(1, x + 1):
        print(str(q) + " ", end="")
        q += 1
    q -= 1
    q = q - ((x - 1) * 2)
    print()