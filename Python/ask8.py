def cl(x):
    i=0
    while x!=1:
        if x%2==0:
            x=x/2
            i+=1
        else:
            x=x*3+1
            i+=1             
maxk=0
for j in range(1,101):
    k=cl(j)
    if k>maxk: 
        max=j
print("The number with the most steps needed to get to 1 is: ",max)