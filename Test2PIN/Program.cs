// Enne süsteemi sisenemist kasutaja peab sisestama oma PIN-koodi.
// Seejärel, kui sisestatud PIN-kood on õige, siis kasutaja saab sisestada ka oma kasutajatunnust ja parooli.
// Süsteemi sisse kasutaja pääseb vaid siis, kui kõik küsitud andmed on õigesti sisestatud.

// Kontrolliandmed:
// PIN-kood: 1234
// Kasutajatunnus: admin1
// Parool: admin1234


string userPIN, userName, password;
Console.WriteLine("Enter PIN:");
userPIN = (Console.ReadLine());

if (userPIN == "1234")
{
    Console.WriteLine("Enter your username:");
    userName = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    password = Console.ReadLine();

    if (userName == "admin1" && password == "admin1234")
    {
        Console.WriteLine("Welcome.");
    }
    else
    {
        Console.WriteLine("Invalid login credentials.");
    }
}

else
{
    Console.WriteLine("Invalid PIN");
}