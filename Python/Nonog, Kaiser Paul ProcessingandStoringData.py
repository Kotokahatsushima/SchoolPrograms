#Programmed by: Nonog, Kaiser Paul C.
import math
def dataInputOutput():
    print(divider)
    print(f'''
            ┌───────────────────────────┐
            │      Data Input and       │
            │          Output           │
            └───────────────────────────┘ ''')
    divider = '────────────────────────────────────────────────────────────────────────────'
    #Input
    print(divider)
    Name =input('What is your name? ')
    print(divider)
    Age = input('How old are you? ')
    print(divider)
    Degree = input('What degree did you choose? ')
    print(divider)
    Email = input('Provide your personal Email Address: ')
    print(divider)
    SchoolEmail = input('Provide your school Email Address: ')
    print(divider)
    hobbies = ['','','']
    hobbies[0] = '1. ' + input('List down your three hobbies:\n1. ')
    hobbies[1] = '2. ' + input('2. ')
    hobbies[2] = '3. ' + input('3. ' )
    print(divider)
    skills = ['','','']
    skills[0] = '1. ' + input('List down your three skills.\n1. ')
    skills[1] = '2. ' + input('2. ')
    skills[2] = '3. ' + input('3. ')

    #Process
    print(divider)
    print('Personal Information')
    print(divider)
    print('Name: ' + Name)
    print('Age: ' + Age)
    print('Degree: '+Degree)
    print(divider)
    print('Personal Contact')
    print(divider)
    print('Email: '+Email)
    print('School Email: '+SchoolEmail)
    print(divider)
    print('Hobbies')
    print(divider)
    print(*hobbies, sep='\n')
    print(divider)
    print('Skills')
    print(divider)
    print(*skills, sep='\n')
    print(divider)

def itemListAdder():
    print(f'''
            ┌───────────────────────────┐
            │      Item List Adder      │
            └───────────────────────────┘ ''')
    divider = '──────────────────────────────────────────'
    itemList = ['1. iPhone 12','2. Airpods','3. Nike Shoes','4. ID lace','5. A4tech Mouse','6. A4tech Keyboard','7. Samsung Galaxy J7','8. RedDragon Keyboard','9. Samsung Monitor','10. Chuckie']
    print(*itemList, sep='\n')
    print(divider)
    print('Add 5 more items in the list: ')
    for x in range(5):
        itemList.append(str(x+11)+'. '+input(str(x+11)+'. '))
    print(divider)
    print('The items are: ')
    print(divider)
    print(*itemList, sep='\n')
    print(divider)

def areaCalculator():
    divider = '──────────────────────────────────────────'
    def AreaofSquare():
        print('      ┌───────────────────────────┐')
        print('      │      Area of Square       │')
        print('      └───────────────────────────┘')
        print(divider)
        a = input('Enter Sides Length: ')
        result = float(a)**2
        print('The area of the square is: ', str(result))
        print(divider)
    def AreaofTriangle():
        print('      ┌───────────────────────────┐')
        print('      │     Area of Triangle      │')
        print('      └───────────────────────────┘')
        print(divider)
        a = float(input('Input A: '))
        b = float(input('Input B: '))
        c = float(input('Input C: '))
        semiperimeter = ((a+b+c))/2
        sempf = float(semiperimeter)
        sresult = sempf*(sempf-a)*(sempf-b)*(sempf-c)
        sresf = float(sresult)
        finalresult = math.sqrt(sresf)
        print('The area of the triangle is: ',str(finalresult))
        print(divider)
    def AreaofRectangle():
        print('      ┌───────────────────────────┐')
        print('      │     Area of Rectangle     │')
        print('      └───────────────────────────┘')
        print(divider)
        length = float(input('Insert Length: '))
        width = float(input('Insert Width: '))
        result = length*width
        print('The area of the rectangle is: ', str(result))
        print(divider)
    def AreaofCircle():
        print('      ┌───────────────────────────┐')
        print('      │       Area of Circle      │')
        print('      └───────────────────────────┘')
        pi = math.pi
        print(divider)
        radius = input('Insert Radius: ')
        result = pi*(float(radius))**2
        print('The area of the circle is: ', str(result))
        print(divider)
    def AreaofTrapezoid():
        print('      ┌───────────────────────────┐')
        print('      │     Area of Trapezoid     │')
        print('      └───────────────────────────┘')
        print(divider)
        a = input('Input A: ')
        b = input('Input B: ')
        height = input('Input Height: ')
        result = ((float(a)+float(b))/2)*float(height)
        print('The area of the trapezoid is: ', str(result))
        print(divider)

    print('      ┌───────────────────────────┐')
    print('      │    Area Calculator App    │')
    print('      └───────────────────────────┘')
    print('┌────────────────────────────────────────┐')
    print('│   Commands:                            │')
    print('│────────────────────────────────────────│')
    print('│   squareArea: Area of Square           │')
    print('│   triangleArea: Area of Triangle       │')
    print('│   rectangleArea: Area of Rectangle     │')
    print('│   circleArea: Area of Cricle           │')
    print('│   trapezoidArea: Area of Trapezoid     │')
    print('└────────────────────────────────────────┘\n')


    print(divider)
    terminal = input()
    print(divider)
    try:
        match terminal:
            case 'squareArea':
                    AreaofSquare()
            case 'triangleArea':
                    AreaofTriangle()
            case 'rectangleArea':
                    AreaofRectangle()
            case 'circleArea':
                    AreaofCircle()
            case 'trapezoidArea':
                    AreaofTrapezoid()
            case _:
                    print('Case Error')
                    print(divider)


    except:
        print('Input Error')
        print(divider)
divider = '─────────────────────────────────────────────────────'
print(f'''
            ┌───────────────────────────┐
            │   Processing and Storing  │
            │           Data            │
            └───────────────────────────┘
    ┌───────────────────────────────────────────┐
    │   Commands:                               │
    │───────────────────────────────────────────│
    │   dataInputOutput: Data Input and Output  │
    │   itemListAdder: Item List Adder          │
    │   areaCalculator: Area Calculator         │
    └───────────────────────────────────────────┘\n
      ''')
print(divider)
inputTerminal = input()

match inputTerminal:
    case 'dataInputOutput':
        dataInputOutput()
    case 'itemListAdder':
        itemListAdder()
    case 'areaCalculator':
        areaCalculator()
    case _:
        print('Case Error')
        print(divider)

