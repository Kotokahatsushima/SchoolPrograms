studentAppend, studentsList = None, []

class Students():
    def __init__(self, name, age, id):
        self.name = name
        self.age = age
        self.id = id


    def mainFunction(self):
        global studentsList, studentAppend
        studentAppend = [self.name, self.age, self.id]
        studentsList.append(studentAppend.copy())
        studentAppend.clear()
        for i in range(len(studentsList)):
            print(f"\nName: {studentsList[i][0]}\nAge: {studentsList[i][1]}\nID: {studentsList[i][2]}\n")


number_of_iterations = int(input("How many students would you like to enroll?: "))
for i in range (number_of_iterations):
    Students(input("Input Name: "), input("Input Age: "), input("Input ID: ")).mainFunction()

        
    
        






