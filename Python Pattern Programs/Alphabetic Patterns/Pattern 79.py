for x in 'EDCBA':
 for y in 'ABCDE':
   if y < x:
      print(y, end=" ")
   else:
      print(x, end=" ")
 print()


#Another way

for x in range(69, 64, -1):
    for y in range(65, 70):
      if y < x:
       print(chr(y), end=" ")
      else:
       print(chr(x), end=" ")
    print()