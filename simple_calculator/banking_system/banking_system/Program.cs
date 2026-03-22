Console.Title = "Bel Bank";

int userInput;
string userName;
string password;

Greeting();
Evaluation();

void Loading()
{
    Console.WriteLine("=============================================================================");
}

void Greeting()
{
    Console.WriteLine("Greetings and Welcome to the Bel Bank Banking System");
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("[1]  Create New Account");
    Console.WriteLine("[2]  Login to Existing Account");
    Console.WriteLine("[3]  Exit");
    Console.Write("Select from the options above: ");
    userInput = Convert.ToInt32(Console.ReadLine());    
}

void Evaluation()
{
    if (userInput == 3)
    { 
        Console.WriteLine("Thank you for using the Bel Banking System.");
        Console.WriteLine("Have a good day.");
        Loading();
    }
    while (userInput != 3)
    {
        if (userInput < 1 || userInput > 3)
        {
            Loading();
            Console.WriteLine("Invalid command, try again.");
            Loading();
            Greeting();
        }
        else if (userInput > 0 || userInput < 4)
        {
            switch (userInput)
            {
                case 1:
                    Loading(); 
                    Console.WriteLine("Welcome to the Account Creation.");
                    Console.WriteLine("Please input the necessary information.");
                    Loading();
                    break;
                case 2:
                    Loading();
                    Console.WriteLine("Please input your username and password below:");
                    Console.Write("Username: ");
                    userName = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    Loading();
                    break;
            }
        }

    }
}

