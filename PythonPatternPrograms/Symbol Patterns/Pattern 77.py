n = 5 # size
px = n #print control
py = n

for x in range(1, n+1):
    for y in range(1, n*2):
        if y == px or y == py or x == n:
            print("*", end="")
        else:
            print(" ", end="")
    px-=1
    py+=1
    print()