Console.Title = "Simple Calculator";
int choice;
float numOne;
float numTwo;


Console.WriteLine("Welcome to the Simple Calculator");
Loading();
Selector();
Evaluator();
Program();
while (choice != 5)
{
    Selector();
    Evaluator();
    Program();
}



void Loading()
{
    Console.WriteLine("============================================================================");
}

void Selector()
{
    Console.WriteLine($"[1] Addition");
    Console.WriteLine($"[2] Subtraction");
    Console.WriteLine($"[3] Multiplication");
    Console.WriteLine($"[4] Division");
    Console.WriteLine($"[5] Quit");
    Console.Write("Please select desired operation from the options above: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

void Evaluator()
{
    if (choice == 5)
    {
        Console.WriteLine("Terminating Program...");
        Loading();
    }
    while (choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid input. Try again.");
        Selector();
        Loading();
    }
    switch (choice)
    {
        case 1:
            Console.WriteLine("Operation selected: Addition");
            Loading();
            break;
        case 2:
            Console.WriteLine("Operation selected: Subtraction");
            Loading();
            break;
        case 3:
            Console.WriteLine("Operation selected: Multiplication");
            Loading();
            break;
        case 4:
            Console.WriteLine("Operation selected: Division");
            Loading();
            break;
    }
}

void Program()
{
    switch (choice)
    {
        case 1:
            UserNumberInput();
            float sum = numOne + numTwo;
            Console.WriteLine($"The result is: {sum}");
            Loading();
            break;
        case 2:
            UserNumberInput();
            float difference = numOne - numTwo;
            Console.WriteLine($"The result is: {difference}");
            Loading();
            break;
        case 3:
            UserNumberInput();
            float product = numOne * numTwo;
            Console.WriteLine($"The result is: {product}");
            Loading();
            break;
        case 4:
            UserNumberInput();
            float quotient = numOne / numTwo;
            Console.WriteLine($"The result is: {quotient}");
            Loading();
            break;
    }

    void UserNumberInput()
    {
        Console.Write("Input first number : ");
        numOne = Convert.ToSingle(Console.ReadLine());
        Console.Write("Input second number: ");
        numTwo = Convert.ToSingle(Console.ReadLine());
    }
}


