"""
 The sequence which is generated from a pattern of dots which form a triangle is known as Triangular Number Sequence.
"""

n = 5  # size

for x in range(1, n + 1):
    num = (x * (x + 1)) // 2
    print(" " + str(num), end="")

    """
 OUTPUT:

 1 3 6 10 15

    """