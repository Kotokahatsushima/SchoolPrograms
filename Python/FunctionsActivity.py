def main():
    n=int(input("Enter Number: "))
    func2(n)
    print(func3(n))
def func2(n, x=0, product=1):
    while x<n:
        x+=1
        print(x)
def func3(n, x=0, product=1):
    while x<n:
        x+=1
        product*=x
    return product
main()