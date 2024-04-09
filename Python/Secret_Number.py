secret_number=9
i=0
guess=int(input("Guess: "))
while guess!=secret_number and i<2:
    guess=int(input("Guess: "))
    i=i+1 
if guess==secret_number:
    print ("Well done, secret number was: ",guess)
else:
    print ("Sorry, no more tries left. You didn't find the secret number.")    