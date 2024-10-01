

int nameHp = 100;
int MONSTERhp = 100;


string Monstername = " Super Mario";


Console.WriteLine("Write your username.");
string name = Console.ReadLine();

while ( name.Length < 4 && name.Length > 20)
{
    Console.WriteLine("Write the name you want to fight with. correctly idiot");

}
if (name.Length <4 )
{
    Console.WriteLine("Your name is to short");
    Console.WriteLine("pleas choose a longer name");
}
else if ( name.Length > 20)
{
    Console.WriteLine("your name is to long");
    Console.WriteLine("pleas choose a shorter name");
}

Console.Clear();
Console.WriteLine("\nWelcome " + name);
Console.WriteLine("You will now fight against super Mario");
Console.ReadKey();


Console.Clear();

Console.WriteLine("Level 1");
Console.WriteLine("Press enter when you are ready for the fight");
Console.ReadKey();

Console.Clear();


while (nameHp > 0 && MONSTERhp > 0)
{
    Console.WriteLine("\n-------=========== FIRST ROUND ===========-------");
    Console.WriteLine($"{name}: {nameHp} , {Monstername}: {MONSTERhp}\n");

    int nameDamage = Random.Shared.Next(10);
    MONSTERhp -= nameDamage;
    MONSTERhp = Math.Max(0, MONSTERhp);
    Console.WriteLine($"{name} has damaged {nameDamage} skada på {MONSTERhp}");

    int MonsterDamage = Random.Shared.Next(10);
    nameHp -= MonsterDamage;
    nameHp = Math.Max(0, nameHp);
    Console.WriteLine($"{Monstername} has damaged {MonsterDamage} skada på {nameHp}");

    Console.WriteLine("press enter to continue");
    Console.ReadLine();

}

Console.WriteLine("\n-------=========== GAME ENDED ===========-------");

if (nameHp == 0 && MONSTERhp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (nameHp == 0)
{
  Console.WriteLine($"{Monstername} vann!");
}
else
{
  Console.WriteLine($"{name} vann!");
}

Console.WriteLine("press enter to exit the game");
Console.ReadKey();
