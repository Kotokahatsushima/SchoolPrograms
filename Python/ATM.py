balance = 100

def main():
    print(f'''
Actions:
1: Balance Inquiry 
2: Withdraw Money 
3: Deposit Money 
4: Exit ATM 
        ''')
    action = input("Input Action: ")
    match action:
        case '1':
            balanceInquiry()
            main()
        case '2':
            withdrawMoney()
            main()
        case '3':
            depositMoney()
            main()
        case '4':
            exit()
        case _:
            print("Action Not Found!")
            main()


def balanceInquiry():
    global balance
    print("Current Balance is: ", balance, "\n")


def withdrawMoney():
    global balance
    withdraw =  int(input("Enter Amount to Withdraw: "))
    if withdraw <= balance:
        balance -= withdraw
        print("Withdrawn", withdraw)
        print("Remaining Balance is: ", balance, "\n")
    else:
        print("Insufficient Funds!")


def depositMoney():
    global balance
    deposit = int(input("Enter Amount to Deposit: "))
    balance += deposit
    print("New Balance is: ", balance, "\n")


main()