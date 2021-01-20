string = "PythonPattern"
strlen = len(string)
for x in range(0, strlen):
    print(string[0:x + 1])
for y in range(0, strlen):
    print(string[0:strlen - y])
