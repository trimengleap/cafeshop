using CoffeClient;

CoffeHelper.BaseUrl = "https://localhost:7242";
A:
Console.WriteLine(new string('=', 120));
Console.WriteLine("\t\t\t\t\t|\t Login \t\t|");
Console.WriteLine(new string('=', 120));
Console.Write("\t\t\t\t\t Enter your username: ");
var user=Console.ReadLine();
Console.Write("\t\t\t\t\t Enter your password: ");
var pass=Console.ReadLine();
if(user=="samut" && pass == "123")
{
    Console.Clear();
    Console.WriteLine(new string('=', 120));
    Console.WriteLine("\t\t\t\t\t |\t Coffe Shop Management\t|");
    Console.WriteLine(new string('=', 120));
    CoffeHelper.MenuBank.MenuSimulate(() => { Console.WriteLine(); });
}
else
{
    Console.WriteLine("Invalid data.........");
    goto A;
}


