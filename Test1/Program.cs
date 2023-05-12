// Rakendus - kehamassiindeksi kalkulaator.
// BMI Categories:
// Underweight = < 19
// Normal weight = 19 - 25
// Overweight = 25 - 30
// Obesity  = > 30

double height, weight;
double userBMI;
Console.WriteLine("Enter your height in cm:");
height = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your weight in kg:");
weight = Int32.Parse(Console.ReadLine());

userBMI = Math.Round((weight / (height * height) * 10000));
Console.WriteLine($"test {userBMI}");
if (userBMI < 19)
{
    Console.WriteLine("Underweight");
}
else if (userBMI >= 19 && userBMI < 25)
{
    Console.WriteLine("Normal weight.");
}
else if (userBMI >= 25 && userBMI <= 30)
{
    Console.WriteLine("Overweight");
}
else
{
    Console.WriteLine("Obesity");
}
