string = "ABCDE"

for x in range(0, 5):
 for y in range(0, 5):
  if x == 2:
   print(string[y],end=" ")
  elif y == 2:
   print(string[x],end=" ")
  else:
   print(" ",end=" ")
 print("")