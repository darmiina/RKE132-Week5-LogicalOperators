// Math >=90 OR Chemistry >=90; 

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 || chemistry >= 90)
{
    Console.WriteLine("Congrulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}

// math && chemistry || math && biology || chemistry && biology

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && chemistry >= 90 || math >= 90 && biology >= 90 || chemistry >= 90 && biology >= 90)
{
    Console.WriteLine("Congrulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}

