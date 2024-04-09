import random
mylist=[]
for i in range(10):
    x=random.randint(100,100000)
    mylist[i]=x
    if x<1500:
        print("VILLAGE",x)
    elif x<25000:
        print("TOWN",x)
    else:
        print("CITY",x)
f=open("plithismoi.txt","x")   
f.write(print(mylist()))
f.close() 