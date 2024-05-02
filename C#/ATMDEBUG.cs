// See https://aka.ms/new-console-template for more information
string uname = "CC3Laboratory", userString = "";
    int password = 12345, balance = 10000, pin = 123456, userInt = 0;
    
    do
    {
        Console.Write("Enter Username: ");
        userString = Console.ReadLine();
        
        Console.Write("Enter Password: ");
        userInt = Convert.ToInt32(Console.ReadLine());
        
        if(userString != uname || userInt != password)
        {
            Console.WriteLine("Incorrect Login Credentials!");
        }
    }
    while(userString != uname || userInt != password);
    bool running = true;
    while(running)
        {
            Console.WriteLine("\nLogin Success!\n");
            {
        Console.WriteLine( 
                    "\n\n================================================================== \n" + 
                    "\n [1] Check Balance" + 
                    "\n [2] Withdraw Money" +  
                    "\n [3] Deposit Money" + 
                    "\n [4] Exit Application\n" + 
                    "\n================================================================== \n");
        
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.Write("You balance is " + balance);
                break;
            case 2:
                
                do{
                    Console.Write("Enter your PIN: ");
                    userInt = Convert.ToInt32(Console.ReadLine());
                    
                    if(userInt != pin)
                        Console.WriteLine("Incorrect Login Credentials!");
                }
                while(userInt != pin);
                {
                    withdraw:
                    Console.Write("Enter the amount to Withdraw: ");
                    userInt = Convert.ToInt32(Console.ReadLine());
    
    
                    switch(userInt <= balance)
                    {
                        case true:
                            balance = balance - userInt;
                            Console.WriteLine(
                                "Successfully Withdrawn!" + 
                                "Your balance is now: " + balance);
                            break;
                        case false:
                            Console.WriteLine(
                                "\nYour Balance is not enough!\n");
                                goto withdraw;
                                break;
                    }
                break;
                }
            case 3:
                Console.Write("Enter the amount to Deposit: ");
                userInt = Convert.ToInt32(Console.ReadLine());
                balance = balance + userInt;
                Console.WriteLine(
                    "\nDeposit Successfull! \n" +
                    "Your balance is now: " + balance);
                break;
            case 4:
                Console.WriteLine("Bye broke human");
                running = false;
                break;
        }
    }
}
