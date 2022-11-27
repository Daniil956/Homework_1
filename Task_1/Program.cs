Console.Clear();
Console.WriteLine("Enter two numbers: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());

if ( a > b )
{
    Console.WriteLine($"Число {a} больше, чем число {b}");
}
else
{
    Console.WriteLine($"Число {b} больше, чем число {a}");
}