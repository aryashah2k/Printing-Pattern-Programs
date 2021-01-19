n=4 #size
p=1
c=1
for x in range(1, n+1):
    for y in range(n-1, x-1, -1):
        print(" ", end=" ")
    p=1
    print(p, end=" ")

    while (c<x):
        p *= 2
        print(p,end=" ")
        c += 1

    while (c > 1):
        p //= 2
        print(p, end=" ")
        c -= 1

    print()