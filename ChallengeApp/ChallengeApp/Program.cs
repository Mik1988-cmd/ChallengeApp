//zadeklaruj zmienna z imieniem
var name = "Ewa";
//zadeklaruj zmienna z plcia
var gender = "Kobieta";
//zadeklaruj zmienna z wiekem
var age = 33;
//zweryfikuj dane i wyswietl ponizsze komunikaty
//kobieta ponizej 30 lat
//Ewa ma 33 lata
//niepelnoletni mezczyzna

if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa ma 33 lata");
}
else if (gender == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta powyzej 30 lat");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepelnotetni mezczyzna");
    }
    else
    {
        Console.WriteLine("Pelnoletni mezczyzna");
    }
}