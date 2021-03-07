n = 10  # size
s1 = n * 2 - 1
s2 = 3

"""
s1 for upper part
s2 for lower part
"""

# upper part
for x in range(1, n + 1):
    for y in range(1, x):
        print("  ", end="")
    for z in range(1, s1 + 1):
        print("*", end="")
    s1 -= 2
    print()

# lower part
for x in range(1, n):
    for y in range(n - 1, x, -1):
        print("  ", end="")
    for z in range(1, s2 + 1):
        print("*", end="")
    s2 += 2
    print()