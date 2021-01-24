#Another way

for x in range(65, 70):
    for y in range(65, 70):
      if y < x:
       print(chr(x), end=" ")
      else:
       print(chr(y), end=" ")
    print()
