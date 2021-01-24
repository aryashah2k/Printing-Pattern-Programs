n=4 #size
pc=0
for x in range(1, n+1):
  for y in range(n-1, x-1, -1):
    print(" ", end=" ")
  for z in range(x-1,-x, -1):
    print(chr(pc-abs(z)+65), end=" ")
  pc+=2
  print()

"""
65 > ASCII of 'A'
"""