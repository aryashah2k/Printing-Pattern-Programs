for x in 'EDCBA':
 for y in 'ABCDE':
   if y < x:
      print(x, end=" ")
   else:
      print(y, end=" ")
 print()


#Another way

for x in range(69, 64, -1):
    for y in range(65, 70):
      if y < x:
       print(chr(x), end=" ")
      else:
       print(chr(y), end=" ")
    print()
