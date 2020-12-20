"""
If a sequence of values follows a pattern of adding a fixed amount from one term to the next, it is referred to as an arithmetic sequence. The number added to each term is constant is called as the common difference, d.

e.g.

1, 4, 7, 10, 13, 16, ...

An arithmetic sequence starts with term(a) 1 and having common difference (d) of 3.

"""

n = 5  # limit or size
d = 3  # common diff
a = 1  # terms

for x in range(1, n + 1):
    print(" " + str(a), end="")
    a = a + d

    """
 OUTPUT:

 1 4 7 10 13

    """