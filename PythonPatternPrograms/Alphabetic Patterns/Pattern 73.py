n = 4
for x in range(n, -1, -1):
    for y in range(0, n+1):
      if y > x:
        print("*", end=" ")
      else:
        print(chr(y+65), end=" ")
    print()

"""
65 > ASCII of 'A'
"""