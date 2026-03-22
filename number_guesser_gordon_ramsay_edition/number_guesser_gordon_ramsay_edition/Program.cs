Console.WriteLine($"*In Gordon Ramsay's voice*");
Console.WriteLine("For our challenge today each chef will designate a number while the other team will try to guess it.");
Console.WriteLine("Blue team, you will guess what the Red team's number is.");
Console.Write("Red team, your number please: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 0 || number > 100)
{
    Console.Write("Again Red team, your number please: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("YOU FUCKING DONKEY! Start again.");
}
Console.Clear();
Console.Write("Alright Blue team, now try to guess the number: ");
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
            Console.WriteLine($"{answer} is raw it can still fly that pigeon!");
        }
        else if (answer > number)
        {
            Console.WriteLine($"{answer} is way too fucking overcooked!");
        }
        else
        {
            Console.WriteLine($"{answer} is correct!");
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
else
{
    Console.WriteLine($"{answer} is correct!");
    Console.WriteLine("Press any key to quit.");
    Console.ReadKey();
}
