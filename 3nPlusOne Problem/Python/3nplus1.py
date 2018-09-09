def CycleCount(tnum):
    anum = tnum
    count = 1
    while anum != 1:
        if anum % 2 == 0:
            anum = anum / 2
        else:
            anum = 3*anum + 1
        count = count + 1
    return count
def MaxCycleCoutn(num1,num2):
    max = 0
    while num1 <= num2:
        if max <= CycleCount(num1):
            max = CycleCount(num1)
        num1 = num1 + 1
    return max

    
# Below is just a run function to see output
print "What is the number"
fnum = raw_input()
print CycleCount(int(fnum))
print "enter first number in range"
anum1 = raw_input()
print "enter second number in range"
anum2 = raw_input()
print MaxCycleCoutn(int(anum1), int(anum2))