var name = "Szymon";
bool women = false;
var age = 15;


if (women == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta, poniżej 30");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}

else if (!women && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
