n = 8  # size

# array with zero fill
arr = [[0 for x in range(n)] for x in range(n)]

x=0
y=0
z=0

for ot in range((n // 2)+1):
    if ot == n // 2:
        z -= 1

    for j in range(y, n - y):
        arr[x][j] = z
        z += 1

    for i in range(x + 1, n - x - 1):
        arr[i][n - y - 1] = z
        z += 1

    for j in range(n - y - 1, y-1,-1):
        arr[n - x - 1][j] = z
        z += 1

    for i in range(n-x-2,x,-1):
        arr[i][y] = z
        z += 1

    x+=1
    y+=1

for a in range(n):
    for b in range(n):
        if arr[a][b]>=26:
            arr[a][b]%=26 #reset
        print(" "+chr(arr[a][b]+65), end="")
    print()