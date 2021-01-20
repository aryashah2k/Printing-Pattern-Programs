n=5
for x in range(0, n):
  for y in range(0, x+1):
    for z in range(0, y + 1):
      print(chr(x+65), end="")
    print()
  print()

"""
65 > ASCII of 'A'
"""