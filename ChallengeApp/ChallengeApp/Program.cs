string name = "Konrad";
char sex = 'm';
int age = 28;

if (age < 30 && sex == 'm')
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (name == "Konrad" && age == 28)
{
    Console.WriteLine("Konrad, lat 28");
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
