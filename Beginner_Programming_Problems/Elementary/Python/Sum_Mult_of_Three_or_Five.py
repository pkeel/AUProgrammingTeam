num = raw_input("Please pick a number: ")
aSum = 0
for x in range(1,int(num)+1):
    if x % 3 == 0 or x % 5 == 0:
        aSum+=x

print aSum