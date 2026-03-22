Console.Write("User 1, enter a number between 0 and 100: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 && number > 100)
{
    Console.WriteLine("Read the instruction again and pick another number!");
}
else 
{
    Console.WriteLine("Number logged, proceeding to next phase of program");
    Console.Clear();
}
Console.Write("User 2, guess the number: ");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer != number)
{
    Console.WriteLine("Number is wrong.");
    while (answer != number)
    {
        Console.Write("What is your next guess? ");
        answer = Convert.ToInt32(Console.ReadLine());
        if (answer < number)
        {
            Console.WriteLine($"{answer} is too low!");
        }
        else if (answer > number)
        {
            Console.WriteLine($"{answer} is too high!");
        }
        else
        {
            Console.WriteLine($"{answer} is correct!");
        }
    }
}
else
{
    Console.WriteLine($"{answer} is correct!");
}
