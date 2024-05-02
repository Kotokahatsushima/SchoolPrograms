items = []
x, y, z, a = 0, 0, 0, 1
n = int(input("Input how many items: "))
while n<=13:
    x += 1
    items.append(input("Enter Item "+str(x)+": "))
    if x==n:
        print("Your Natural Number is: ")
        while n<=13:
            print(str(y+1)+". "+items[y])
            y += 1
            if y==n:
                break
        print("Your Reversed Number is: ")
        while n<=13:
            print(str(a)+". "+items[z-1])
            a += 1
            z -= 1
            if z==n*-1:
                break
        break
        


