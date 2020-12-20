n = 15  # upper limit
a = 0
b = 1
c = a + b
while (c <= n):
    print(" " + str(c), end="")
    c = a + b
    a = b
    b = c

    """
 OUTPUT:

 1 1 2 3 5 8 13

    """