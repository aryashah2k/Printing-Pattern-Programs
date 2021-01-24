size=4
for x in range(size, -size-1, -1):
    for y in range(0, abs(x)+1):
      print(chr(y+65), end=" ")
    print()

"""
65 > ASCII of 'A'
"""