class Lion():
    def __init__(self, name, gender, age, hungerlevel):
        self.name = name
        self.gender = gender
        self.age = age 
        self.hungerlevel = hungerlevel


    def Roar(self):
        print(f"{self.name} Rawrs")

        
    def Eat(self):
        print(f"*{self.name} eats one human")
        self.hungerlevel += -5


    def PrintInfos(self):
        hungerlevel = "very hungry" if self.hungerlevel > 4 else "not hungry"
        print(f'''
The lion's name is {self.name} and its gender is {self.gender}. It is {self.age} years old. {self.name} is {hungerlevel}  
''')


class Anteater():
    def __init__(self, name, age, gender):
        self.name = name
        self.gender = gender
        self.age = age


    def TPose(self):
        print(f"*{self.name} does a T-Pose to intimidate you!")


    def LickThemAnts(self):
        print(f"*{self.name} licks the ants to fill up its stomach")
    

    def PrintInfos(self):
        print(f'''
The anteater's name is {self.name} and its gender is {self.gender}. It is {self.age} years old.
''')
        

class Pikachu():
    def __init__(self, name, age, gender, level):
        self.name = name
        self.gender = gender
        self.age = age
        self.level = level
    

    def ThunderBolt(self):
        print(f"{self.name} does Thunder Bolt!")

    
    def WildCharge(self):
        print(f"{self.name} does Wild Charge")


    def PrintInfos(self):
        print(f'''
The high voltage yellow rat's name is {self.name}. It is a {self.gender} and is {self.age} years old. This high voltage rat is level {self.level}.
''')
  
  
#Objects
lion = Lion("Ulla Britta", "female", 23, 5)
anteater = Anteater("Pedro Kamatis", 4, "male")
pikachu = Pikachu("Li Alejandre", 20, "male", 76)
def main():
    actionInput = int(input('''Input Action: 
1: Select Lion
2: Select Anteater
3: Select Pikachu
4: Exit
'''))
    match actionInput:
        case 1:
            selectLion()
        case 2:
            selectAnteater()
        case 3:
            selectPikachu()
        case 4:
            exit()
        case _:
            print("Invalid Input")
            main()


def selectLion():
    global lion
    actionInput =  int(input('''Input Action:
1: Roar
2: Eat
3: Print Information
4: Rename Lion
5: Exit
'''))
    match actionInput:
        case 1:
            lion.Roar()
            selectLion()
        case 2:
            lion.Eat()
            selectLion()
        case 3:
            lion.PrintInfos()
            selectLion()
        case 4:
            lion = Lion(input("Input Name: "), "female", 23, 5)
            selectLion()
        case 5:
            exit()
        case _:
            print("Invalid Input")
            selectLion()


def selectAnteater():
    global anteater
    actionInput =  int(input('''Input Action:
1: Tpose
2: Lick Them Ants
3: Print Information
4: Rename Anteater
5: Exit
'''))
    match actionInput:
        case 1:
            anteater.TPose()
            selectAnteater()
        case 2:
            anteater.LickThemAnts() 
            selectAnteater()
        case 3:
            anteater.PrintInfos()
            selectAnteater()
        case 4:
            anteater = Anteater(input("Input Name: "), 4, "male")
            selectAnteater()
        case 5:
            exit()
        case _:
            print("Invalid Input")
            selectAnteater()
            

def selectPikachu():
    global pikachu
    actionInput =  int(input('''Input Action:
1: Thunder Bolt
2: Wild Charge
3: Print Information
4: Rename Pikachu
5: Exit
'''))
    match actionInput:
        case 1:
            pikachu.ThunderBolt()
            selectPikachu()
        case 2:
            pikachu.WildCharge()
            selectPikachu()
        case 3:
            pikachu.PrintInfos()
            selectPikachu()
        case 4:
            pikachu = Pikachu(input("Input Name: "), 20, "male", 76)
            selectPikachu()
        case 5:
            exit()
        case _:
            print("Invalid Input")
            selectPikachu()


main()