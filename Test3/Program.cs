string userName, password;

Console.WriteLine("Enter your username:");
userName = Console.ReadLine();
Console.WriteLine("Enter your password:");
password = Console.ReadLine();

if (userName != "admin" && password != "admin1234")
    {
    Console.WriteLine("Invalid login credentials.");
}
    else
{
    Console.WriteLine("Welcome!");
}