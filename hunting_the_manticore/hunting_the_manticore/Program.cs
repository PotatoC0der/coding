using System.Runtime.CompilerServices;

Console.Title = "Hunting the Manticore";
// variables start
int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int cannonRange;
// variables end

// methods start
void GameStatus(int round)
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
}

int CannonDamageComputation(int round)
{
    bool fireBlast = round % 3 == 0;
    bool electricBlast = round % 5 == 0;
    if (fireBlast && electricBlast) return 10;
    if (fireBlast || electricBlast) return 3;
    return 1;
}

void CannonTrajectory(int cannonRange, int target)
{
    if (cannonRange == target) Console.WriteLine("That round was a DIRECT HIT!");
    if (cannonRange > target) Console.WriteLine("That round OVERSHOT the target.");
    if (cannonRange < target) Console.WriteLine("That round FELL SHORT of the target.");
}
// methods end

// main program start
Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Player 2, it is you turn");
Console.WriteLine("-----------------------------------------------------------------");
while (manticoreHealth > 0 && cityHealth > 0)
{
    int cannonDamage = CannonDamageComputation(round);
    GameStatus(round);
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    Console.Write($"Enter desired cannon range: ");
    cannonRange = Convert.ToInt32(Console.ReadLine());
    CannonTrajectory(cannonRange, distance);
    if (cannonRange == distance)
        {
            manticoreHealth -= cannonDamage;
        }
    if (manticoreHealth > 0)
        {
        cityHealth--;
        }
    Console.WriteLine("-----------------------------------------------------------------");
    round++;
}
if (manticoreHealth <= 0)
{
    Console.WriteLine("The Manticore has been destroyed! The city is saved.");
}
else if (cityHealth <= 0) 
{
    Console.WriteLine("City is destroyed! Mission failed.");
}

// main program end