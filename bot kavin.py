import random
i = 1
while i == 1:
    kavin = input("Say something: ")
    if kavin == "kanishk":
        rand1 = random.randint(1,3)
        if rand1 == 1:
             print("Oh no kanishk throwed the ball")
        elif rand1 == 2:
            print("Oh no kanishk is falling down")
        else:
            print("Oh no kanishk is a hamster")
    elif kavin == "exit":
        exit()
    elif kavin == "intelligent":
        print("Do not scold")
    elif kavin == "fool":
        name = input("Wait what is your name: ")
        print("i am not the fool",name,"is a fool")
    else:
        print("What are you saying?")
