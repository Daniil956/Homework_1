Console.Clear();
Console.WriteLine("Enter three numbers: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double q = Convert.ToInt32(Console.ReadLine());

double max = a;

if (max < b)
{
    max = b;
}
if (max > q)
{
Console.WriteLine($"Самое большое число: {max}");
}
else 
{
Console.WriteLine($"Самое большое число: {q}");
}