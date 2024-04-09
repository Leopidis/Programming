Weight =input ("Weight: ")
Type = input ("(K)g or (L)bs ")
if Type == "k" or Type == "K": 
    print ("Weight in pounds: ",float(Weight)*2.20462)
elif Type == "l" or Type == "L":
    print ("Weight in kilograms: ",float(Weight)*0.453592) 
    
#ENALLAKTIKH LYSH    

Weight =input ("Weight: ")
Type = input ("(K)g or (L)bs ")
if Type.upper()=="K":
    print ("Weight in pounds: ",float(Weight)*2.20462)
elif Type.upper()=="L":
    print ("Weight in kilograms: ",float(Weight)*0.453592)     