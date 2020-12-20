"""
If a sequence of values follows a pattern of multiplying a fixed amount times each term to arrive at the following term, it is referred to as a  geometric sequence. The number multiplied each time is constant and  is called as the common ratio, r.
e.g.

 2, 6, 18, 54, ...

An geometric sequence starts with term(a) 2 and having common ratio (r) of 3.

"""

n = 5  # limit or size
r = 2  # common ratio
a = 5  # terms

for x in range(1, n + 1):
    print(" " + str(a), end="")
    a = a * r

    """
 OUTPUT:

 5 10 20 40 80

    """